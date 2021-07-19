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
using System.Runtime;

namespace _20210716_HW
{
    public partial class TaxCalculator : Form
    {
        /// <summary> 自用小客車各個CC數區間對應牌照稅的Hashtable  </summary>
        Hashtable SelfCarCC = new Hashtable()
        {
            {"01. <500cc" , 1620 },
            {"02. 501cc - 600cc"  , 2160    },
            {"03. 601cc - 1200cc" , 4320    },
            {"04. 1201cc - 1800cc", 7120    },
            {"05. 1801cc - 2400cc" ,11230   },
            {"06. 2401cc - 3000cc", 15210   },
            {"07. 3001cc - 4200cc" ,28220   },
            {"08. 4201cc - 5400cc" ,46170   },
            {"09. 5401cc - 6600cc" ,69690   },
            {"10. 6601cc - 7800cc" ,117000  },
            {"11. >7801cc ",   151200        },
        };
        /// <summary> 商用小客車各個CC數區間對應牌照稅的Hashtable  </summary>
        Hashtable BusinessCarCC = new Hashtable()
        {
            {"01. <500cc",  900 },
            {"02. 501cc - 600cc",  1260},
            {"03. 601cc - 1200cc",  2160},
            {"04. 1201cc - 1800cc", 3060},
            {"05. 1801cc - 2400cc", 6480},
            {"06. 2401cc - 3000cc", 9900},
            {"07. 3001cc - 4200cc", 16380},
            {"08. 4201cc - 5400cc", 24300},
            {"09. 5401cc - 6600cc", 33660},
            {"10. 6601cc - 7800cc", 44460},
            {"11. >7801cc",   56700},
        };
        /// <summary> 大客車各個CC數區間對應牌照稅的Hashtable  </summary>
        Hashtable CoachCarCC = new Hashtable()
        {
            {"01. 501cc - 600cc",   1080},
            {"02. 601cc - 1200cc",  1800},
            {"03. 1201cc - 1800cc", 2700},
            {"04. 1801cc - 2400cc", 3600},
            {"05. 2401cc - 3000cc", 4500},
            {"06. 3001cc~3600cc",   5400},
            {"07. 3601cc~4200cc",   6300},
            {"08. 4201cc~4800cc",   7200},
            {"09. 4801cc~5400cc",   8100},
            {"10. 5401cc~6000cc",   9000},
            {"11. 6001cc~6600cc",   9900},
            {"12. 6601cc~7200cc",   1080},
            {"13. 7201cc~7800cc",   1170},
            {"14. 7801cc~8400cc",   1260},
            {"15. 8401cc~9000cc",   1350},
            {"16. 9001cc~9600cc",   1440},
            {"17. 9601cc~10200cc",  1530},
            {"18. >10201cc",  16200     },
        };
        /// <summary> 貨車各個CC數區間對應牌照稅的Hashtable  </summary>
        Hashtable TruckCC = new Hashtable()
        {
            {"01. <500cc",     900 },
            {"02. 501cc - 600cc",   1080},
            {"03. 601cc - 1200cc",  1800},
            {"04. 1201cc - 1800cc", 2700},
            {"05. 1801cc - 2400cc", 3600},
            {"06. 2401cc - 3000cc", 4500},
            {"07. 3001cc~3600cc",   5400},
            {"08. 3601cc~4200cc",   6300},
            {"09. 4201cc~4800cc",   7200},
            {"10. 4801cc~5400cc",   8100},
            {"11. 5401cc~6000cc",   9000},
            {"12. 6001cc~6600cc",   9900},
            {"13. 6601cc~7200cc",   10800},
            {"14. 7201cc~7800cc",   11700},
            {"15. 7801cc~8400cc",   12600},
            {"16. 8401cc~9000cc",   13500},
            {"17. 9001cc~9600cc",   14400},
            {"18. 9601cc~10200cc",  15300},
            {"19> 10201cc",   16200},
        };
        /// <summary> 機車各個CC數區間對應牌照稅的Hashtable  </summary>
        Hashtable MotorcycleCC = new Hashtable()
        {
            {"01. <150cc",    0},
            {"02. 151cc~ 250cc",    800},
            {"03. 251cc~ 500cc",    1620},
            {"04. 501cc~ 600cc",    2160},
            {"05. 601cc~1200cc",    4320},
            {"06. 1201cc~1800cc",   7120},
            {"07. >1801cc",   11230},
        };
        /// <summary> 自用電動小客車各個馬力區間對應牌照稅的Hashtable  </summary>
        Hashtable SelfElectCarHP = new Hashtable()
        {
            {"01. <38HP    <38.6PS",  1620},
            {"02. 38.1-56HP 38.7-56.8PS",   2160},
            {"03. 56.1-83HP 56.9-84.2PS",   4320},
            {"04. 83.1-182HP    84.3-184.7PS",  7120},
            {"05. 182.1-262HP   184.8-265.9PS", 11230},
            {"06. 262.1-322HP   266.0-326.8PS", 15210},
            {"07. 322.1-414HP   326.9-420.2PS", 28220},
            {"08. 414.1-469HP   420.3-476.0PS", 46170},
            {"09. 469.1-509HP   476.1-516.6PS", 69690},
            {"10. >509.1HP >516.7PS",  117000},
        };
        /// <summary> 商用電動小客車各個馬力區間對應牌照稅的Hashtable  </summary>
        Hashtable BusinessElecCarHP = new Hashtable(0)
        {
            {"01. <38HP    <38.6PS",  900 },
            {"02. 38.1-56HP 38.7-56.8PS",   1260},
            {"03. 56.1-83HP 56.9-84.2PS",   2160},
            {"04. 83.1-182HP    84.3-184.7PS",  3060},
            {"05. 182.1-262HP   184.8-265.9PS", 6480},
            {"06. 262.1-322HP   266.0-326.8PS", 9900},
            {"07. 322.1-414HP   326.9-420.2PS", 16380},
            {"08. 414.1-469HP   420.3-476.0PS", 24300},
            {"09. 469.1-509HP   476.1-516.6PS", 33660},
            {"10. >509.1HP >516.7PS", 44460 }
        };
        /// <summary> 電動機車各個馬力區間對應牌照稅的Hashtable  </summary>
        Hashtable ElecMotoHP = new Hashtable()
        {
            {"01. <20.19HP <21.54PS", 0},
            {"02. 20.20-40.03HP 21.55-42.71PS", 800},
            {"03. 40.04-50.07HP 42.72-53.43PS", 1620},
            {"04. 50.08-58.79HP 53.44-62.73PS", 2160},
            {"05. 58.80-114.11HP    62.74-121.76PS",    4320},
            {"06. >114.12HP    >121.77PS",    7120},
        };
        /// <summary> 自用電動大客車各個馬力區間對應牌照稅的Hashtable  </summary>
        Hashtable ElecCoachCarAndTruckHP = new Hashtable()
        {
            {"01. <138HP   <140.1PS", 4500 },
            {"02. 138.1-200HP   140.2-203PS",   6300},
            {"03. 200.1-247HP   203.1-250.7PS", 8100},
            {"04. 247.1-286HP   250.8-290.3PS", 9900},
            {"05. 286.1-336HP   290.4-341PS",   11700},
            {"06. 336.1-361HP   341.1-366.4PS", 13500},
            {"07. >361.1HP >366.5PS", 15300},
        };
        /// <summary> 各個車種中文名與其對應使用Hashtable名的Dictionary  </summary>
        Dictionary<string, string> CarTypeDic = new Dictionary<string, string>()
        {
            {"自用小客車", "SelfCarCar "},
            {"營業用小客車","BusinessCarC"},
            {"大客車","CoachCarCC"},
            {"貨車","TruckCC"},
            {"曳引車","TruckCC"},
            {"機車","MotorcycleCC"},
            {"自用電動小客車","SelfElecCarHP"},
            {"營業用電動小客車","BusinessElecCarHP"},
            {"電動機車","ElecMotoHP"},
            {"電動大客車及貨車","ElecCoachCarAndTruckHP"},
        };


        public TaxCalculator()
        {
            InitializeComponent();
        }
        ///<summary>將各個控制項初始化</summary>///
        private void TaxCalculatorForm_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            Init();
        }
        ///<summary>將各個控制項初始化</summary>///
        private void Init()
        {
            this.carTypeComboBox.SelectedItem = "自用小客車";
            this.CCComboBox.SelectedIndex = 0;
            this.alertLabel.Visible = false;
            if (!this.daysModeRadioButton2.Checked)
            {
                this.startDateTimePicker.Visible = false;
                this.endDateTimePicker.Visible = false;
            }
            this.outputTextBox.Text = string.Empty;
            this.startDateTimePicker.Value = DateTime.Now;
            this.endDateTimePicker.Value = DateTime.Now;
        }
        /// <summary> 輸入車種傳回對應Hashtable </summary>
        private Hashtable GetCarCCHashTable(object obj) 
        {
            switch (obj.ToString())
            {
                case "自用小客車":
                    return SelfCarCC;
                case "營業用小客車":
                    return BusinessCarCC;
                case "大客車":
                    return CoachCarCC;
                case "貨車":
                    return TruckCC;
                case "曳引車":
                    //稅額(HashTable Value)為貨車的130%，CC數範圍相同
                    return TruckCC;
                case "機車":
                    return MotorcycleCC;
                case "自用電動小客車":
                    return SelfElectCarHP;
                case "營業用電動小客車":
                    return BusinessElecCarHP;
                case "電動機車":
                    return ElecMotoHP;
                case "電動大客車及貨車":
                    return BusinessElecCarHP;
                default:
                    return new Hashtable() { { "讀取失敗",-1} };
            }
        }
        private void carTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CCComboBox.Items.Clear();
            string a = this.CCComboBox.SelectedItem as string;
            List<string> list = new List<string>();
            foreach (string key in GetCarCCHashTable(this.carTypeComboBox.SelectedItem.ToString()).Keys) 
            {
                list.Add(key);
            }
            list.Sort();
            foreach(string temp in list)
            {
                this.CCComboBox.Items.Add(temp);
            }
            this.CCComboBox.SelectedIndex = 0;
        }

        private void comfirmButton_Click(object sender, EventArgs e)
        {
            ShowResultText();
        }
        private void yearModeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.outputTextBox.Text = string.Empty;
            this.startDateTimePicker.Visible = false;
            this.endDateTimePicker.Visible = false;
        }
        private void daysModeRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.outputTextBox.Text = string.Empty;
            this.startDateTimePicker.Visible = true;
            this.endDateTimePicker.Visible = true;
        }
        /// <summary> 回傳全年度模式(yearmode)下，Combobox選取車種的牌照稅 </summary>
        private Decimal GetYearTax()
        {
            object obj = this.carTypeComboBox.SelectedItem;
            Hashtable temp = GetCarCCHashTable(obj);
            object tax = temp[this.CCComboBox.SelectedItem.ToString()];
            //曳引車牌照稅依貨車加收30%
            if (obj.ToString() == "曳引車")
                return (Convert.ToDecimal(tax)*1.3m);
            else
                return (Convert.ToDecimal(tax));
        }
        /// <summary> 回傳依期間模式(daysmode)下，Combobox選取車種的牌照稅(起始年分天數的牌照稅+中間經過幾年*每年牌照稅+結束年分天數的牌照稅)  </summary>
        private Decimal GetDaysTax(decimal yearTax)
        {
            DateTime startdate = this.startDateTimePicker.Value;
            DateTime enddate = this.endDateTimePicker.Value;
            decimal daysTax;
            //開始、結束不同年分
            if (startdate.Year != enddate.Year)
            {
                int[] tempArr = GetDuration();
                decimal startYearDays = Convert.ToDecimal((new DateTime(startdate.Year, 12, 31) - startdate).TotalDays) + 1;
                decimal endYearDays = Convert.ToDecimal((enddate - (new DateTime(enddate.Year, 1, 1))).TotalDays) + 1;
                decimal years = (tempArr[1] - 1) > 0 ? (tempArr[1] - 1) : 0;
                //考慮起始年分、結束年分分別是否為閏年的4種情況
                if (DateTime.IsLeapYear(startdate.Year) && DateTime.IsLeapYear(enddate.Year))
                {
                    daysTax = yearTax * startYearDays / 366m + yearTax * endYearDays / 366m + yearTax * years;
                    return Math.Truncate(daysTax);
                }
                else if (!DateTime.IsLeapYear(startdate.Year) && DateTime.IsLeapYear(enddate.Year))
                {
                    daysTax = yearTax * startYearDays / 365m + yearTax * endYearDays / 366m + yearTax * years;
                    return Math.Truncate(daysTax);
                }
                else if (DateTime.IsLeapYear(startdate.Year) && !DateTime.IsLeapYear(enddate.Year))
                {
                    daysTax = yearTax * startYearDays / 365m + yearTax * endYearDays / 365m + yearTax * years;
                    return Math.Truncate(daysTax);
                }
                else
                {
                    daysTax = yearTax * startYearDays / 365m + yearTax * endYearDays / 365m + yearTax * years;
                    return Math.Truncate(daysTax);
                }
            }
            //開始、結束同年
            else
            {
                int[] tempArr = GetDuration();
                decimal temp = (DateTime.IsLeapYear(startdate.Year)) ? yearTax * tempArr[0]/366: yearTax * tempArr[0] / 365;
                return Math.Truncate(temp);
            }
        }
        ///<summary>取得開始日期~結束日期的天數與中間經過幾個完整年，若結束天數小於起始天數回傳0。(考慮種樹問題，ex:2021/01/01 ~ 2021/01/01 也算一天)</summary>///
        private int[] GetDuration()
        {           
            if(this.startDateTimePicker.Value > endDateTimePicker.Value)
            {
                return new int[2]{0,0};
            }
            else
            {
                DateTime startdate   =  this.startDateTimePicker.Value;
                DateTime enddate = this.endDateTimePicker.Value;

                int days = (Convert.ToInt32((enddate - startdate).TotalDays))+1;
                int years= (Convert.ToInt32((enddate.Year - startdate.Year)));
                return new int[2] { days, years };
            }
        }
        private void ShowResultText()
        {
            decimal yeartax = GetYearTax();
            if (this.yearModeRadioButton.Checked)
            {
                this.alertLabel.Visible = false;
                this.outputTextBox.Text = yeartax.ToString();
            } 
            else if (this.daysModeRadioButton2.Checked && this.startDateTimePicker.Checked && this.endDateTimePicker.Checked && GetDuration()[0] != 0)
            {
                this.alertLabel.Visible = false ;
                this.outputTextBox.Text = GetDaysTax(yeartax).ToString();
            }
            //錯誤警示:未選取正確的模式
            else if (!this.yearModeRadioButton.Checked && !this.daysModeRadioButton2.Checked)
            {
                this.outputTextBox.Text = "發生錯誤";
                this.alertLabel.Visible = true;
                this.alertLabel.Text = "請選擇全年度或是依期間，\n並重新送出!!";
            }
            //錯誤警示:如果GetDuration()[0] == 0，代表結束時間小於開始時間
            else if(GetDuration()[0] == 0)
            {
                this.outputTextBox.Text = "發生錯誤";
                this.alertLabel.Visible = true;
                this.alertLabel.Text = "起始日期大於結束日期!!\n請選擇正確的起始日期與結束日期，\n並重新送出!!";
            }
            else
            {
                this.outputTextBox.Text = "發生錯誤";
                this.alertLabel.Visible = true;
                this.alertLabel.Text = "發生未知錯誤，請聯繫相關人員!!";
            }
        }
    }
}
