using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace _20210716_HW
{
    public partial class Form1 : Form
    {
        Hashtable selfCarCC = new Hashtable()
        {
            {"<500cc" , 1620 },
            {"501cc - 600cc"  , 2160    },
            {"601cc - 1200cc" , 4320    },
            {"1201cc - 1800cc", 7120    },
            {"1801cc - 2400cc" ,11230   },
            {"2401cc - 3000cc", 15210   },
            {"3001cc - 4200cc" ,28220   },
            {"4201cc - 5400cc" ,46170   },
            {"5401cc - 6600cc" ,69690   },
            {"6601cc - 7800cc" ,117000  },
            {"7801cc ",   151200        },
        };
        Hashtable businessCarCC = new Hashtable()
        {
            {"<500cc",  900 },
            {"501cc - 600cc",  1260},
            {"601cc - 1200cc",  2160},
            {"1201cc - 1800cc", 3060},
            {"1801cc - 2400cc", 6480},
            {"2401cc - 3000cc", 9900},
            {"3001cc - 4200cc", 16380},
            {"4201cc - 5400cc", 24300},
            {"5401cc - 6600cc", 33660},
            {"6601cc - 7800cc", 44460},
            {">7801cc",   56700},
        };

        Hashtable coachCarCC = new Hashtable()
        {
            {"501cc - 600cc",   1080},
            {"601cc - 1200cc",  1800},
            {"1201cc - 1800cc", 2700},
            {"1801cc - 2400cc", 3600},
            {"2401cc - 3000cc", 4500},
            {"3001cc~3600cc",   5400},
            {"3601cc~4200cc",   6300},
            {"4201cc~4800cc",   7200},
            {"4801cc~5400cc",   8100},
            {"5401cc~6000cc",   9000},
            {"6001cc~6600cc",   9900},
            {"6601cc~7200cc",   1080},
            {"7201cc~7800cc",   1170},
            {"7801cc~8400cc",   1260},
            {"8401cc~9000cc",   1350},
            {"9001cc~9600cc",   1440},
            {"9601cc~10200cc",  1530},
            {">10201cc",  16200     },
        };
        Hashtable truckCC = new Hashtable()
        {
            {"<500cc",     900 },
            {"501cc - 600cc",   1080},
            {"601cc - 1200cc",  1800},
            {"1201cc - 1800cc", 2700},
            {"1801cc - 2400cc", 3600},
            {"2401cc - 3000cc", 4500},
            {"3001cc~3600cc",   5400},
            {"3601cc~4200cc",   6300},
            {"4201cc~4800cc",   7200},
            {"4801cc~5400cc",   8100},
            {"5401cc~6000cc",   9000},
            {"6001cc~6600cc",   9900},
            {"6601cc~7200cc",   10800},
            {"7201cc~7800cc",   11700},
            {"7801cc~8400cc",   12600},
            {"8401cc~9000cc",   13500},
            {"9001cc~9600cc",   14400},
            {"9601cc~10200cc",  15300},
            {">10201cc",   16200},
        };

        Hashtable motorcycleCC = new Hashtable()
        {
            {"<150cc",    0},
            {"151cc~ 250cc",    800},
            {"251cc~ 500cc",    1620},
            {"501cc~ 600cc",    2160},
            {"601cc~1200cc",    4320},
            {"1201cc~1800cc",   7120},
            {">1801cc",   11230},
        };
        Hashtable electriclMotoHP = new Hashtable()
        {
            {"<20.19HP <21.54PS", 0},
            {"20.20-40.03HP 21.55-42.71PS", 800},
            {"40.04-50.07HP 42.72-53.43PS", 1620},
            {"50.08-58.79HP 53.44-62.73PS", 2160},
            {"58.80-114.11HP    62.74-121.76PS",    4320},
            {">114.12HP    >121.77PS",    7120},
        };
        Hashtable electricalCoachCarHP = new Hashtable()
        {
            {"<138HP   <140.1PS", 4500 },
            {"138.1-200HP   140.2-203PS",   6300},
            {"200.1-247HP   203.1-250.7PS", 8100},
            {"247.1-286HP   250.8-290.3PS", 9900},
            {"286.1-336HP   290.4-341PS",   11700},
            {"336.1-361HP   341.1-366.4PS", 13500},
            {">361.1HP >366.5PS", 15300},
        };
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
    }
}
