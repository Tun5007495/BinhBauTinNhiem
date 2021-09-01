using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinhBauTinNhiem
{
    class UserUtils

    {
        public static string username = null;
        public enum SubSystem
        {
            Admin,
            NguoiDiBau,
            TruongBanTCBB,
            ToLapDS_NDB,
            BTC_BB,
            ToTheoDoiKQ,
            BP_GiamSat
        }
        public static SubSystem subSystem;
    }
}
