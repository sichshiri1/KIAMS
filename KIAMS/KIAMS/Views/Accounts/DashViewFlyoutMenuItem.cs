using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIAMS.Views.Accounts
{
    public class DashViewFlyoutMenuItem
    {
        public DashViewFlyoutMenuItem()
        {
            TargetType = typeof(DashViewFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}