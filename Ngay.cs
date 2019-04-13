using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUANLYHT
{
    class Ngay
    {
        public int KiemTraNhuan(ComboBox cbYear)
        {
            int year = Convert.ToInt32(cbYear.SelectedItem);
            if (year % 4 == 0 && year % 100 != 0)
                return 1;
            if (year % 400 == 0)
                return 1;
            return 0;
        }
        public int NgayMax(ComboBox cbDate, ComboBox cbMonth, ComboBox cbYear)
        {
            int day = Convert.ToInt32(cbDate.SelectedItem);
            int month = Convert.ToInt32(cbMonth.SelectedItem);

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                    break;
                case 2:
                    {
                        if (KiemTraNhuan(cbYear) == 1)
                            return 29;
                        return 28;
                    }
                default:
                    return 0;
            }
        }
        public int KiemTraHopLe(ComboBox cbDate, ComboBox cbMonth, ComboBox cbYear)
        {
            int month = Convert.ToInt32(cbMonth.SelectedItem);
            int day = Convert.ToInt32(cbDate.SelectedItem);
            if (month >= 1 && month <= 12)
            {
                if (day >= 1 && day <= NgayMax(cbDate, cbMonth, cbYear))
                    return 1;
                return 0;
            }
            return 0;
        }
    }
}
