using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraNavBar;

namespace WindowsApplication1
{
    public class MyNavBarControl : NavBarControl
    {

        private NavBarGroup NextGroup(NavBarGroup group, bool forward)
        {
            if (Groups.Count == 0) //|| (Groups.Count == 1 && group != null)
                return null;
            if (group == null)
                return (forward) ? Groups[0] : Groups[Groups.Count - 1];

            if (forward)
            {
                if (Groups.IndexOf(group) < Groups.Count - 1)
                    return Groups[Groups.IndexOf(group) + 1];
                else
                    return Groups[0];
            }
            else if (Groups.IndexOf(group) > 0)
                return Groups[Groups.IndexOf(group) - 1];
            else
                return Groups[Groups.Count - 1];
        }

        private NavBarItemLink FindNearItemLink(bool forward)
        {
            NavBarItemLink link = SelectedLink;
            NavBarGroup group;
            if (link == null)
                group = NextGroup(null, forward);
            else
                group = link.Group;
            if (group == null)
                return null;
            NavBarGroup startGroup = group;
            int i;
            if (link != null)
                i = group.ItemLinks.IndexOf(link);
            else
                i = (forward) ? -1 : group.ItemLinks.Count;
            bool repeat = false;
            do
            {
                if (forward)
                {
                    if (i < group.ItemLinks.Count - 1)
                        return group.ItemLinks[i + 1];
                    else
                    {
                        group = NextGroup(group, forward);
                        repeat = i > 0;
                        i = -1;
                    }
                }
                else
                {
                    if (i > 0 && group.ItemLinks.Count > 0)
                        return group.ItemLinks[i - 1];
                    else
                    {
                        group = NextGroup(group, forward);
                        repeat = i < group.ItemLinks.Count - 1;
                        i = group.ItemLinks.Count;
                    }
                }
            }
            while (group != startGroup || repeat);
            return null;
        }

        public void SelectNextLink(bool forward)
        {
            SelectedLink = FindNearItemLink(forward);
            if (SelectedLink != null && !SelectedLink.Group.Expanded)
                SelectedLink.Group.Expanded = true;
            ViewInfo.MakeLinkVisible(SelectedLink);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            Keys key = keyData & (~Keys.Modifiers);
            switch (key)
            {
                case Keys.Down:
                    SelectNextLink(true);
                    break;
                case Keys.Up:
                    SelectNextLink(false);
                    break;
                default:
                    return base.ProcessDialogKey(keyData);
            }
            return false;
        }
    }
}
