using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleGraph
{
    public partial class ScheduleMain : Form
    {
        public ScheduleMain()
        {
            InitializeComponent();
        }


        public static void main(string[] args)
        {
            System.Data.DataTable Table = new System.Data.DataTable();
            ScheduleMain 


            Table.Columns.Add("ID", typeof(int));
            Table.Columns.Add("Name", typeof(string));
            Table.Columns.Add("Value", typeof(double));

            Table.Rows.Add(new Object[] { 1, "AAA", 120 });
            Table.Rows.Add(new Object[] { 2, "BBB", 220 });
            Table.Rows.Add(new Object[] { 3, "CCCCC", 60 });
            Table.Rows.Add(new Object[] { 4, "DD", 430 });
            Table.Rows.Add(new Object[] { 5, "E", 800 });
            Table.Rows.Add(new Object[] { 6, "FFFFFFF", 360 });
            Table.Rows.Add(new Object[] { 7, "GGGG", 990 });
            Table.Rows.Add(new Object[] { 8, "HHHHHHHHHHH", 150 });
            Table.Rows.Add(new Object[] { 9, "IIII", 360 });
            Table.Rows.Add(new Object[] { 10, "JJJJJJJ", 960 });
            Table.Rows.Add(new Object[] { 11, "K", 740 });
            Table.Rows.Add(new Object[] { 12, "L", 960 });
            Table.Rows.Add(new Object[] { 13, "MMM", 780 });
            Table.Rows.Add(new Object[] { 14, "N", 800 });
            Table.Rows.Add(new Object[] { 15, "OOOOOOOO", 690 });

            //テーブルのレコードの並び替えを行う。①Value列で降順に並び替える。②Name列で昇順に並び替える。
            DataRow[] Rows = Table.Select("", "Value DESC, Name ASC");

            //Velue列の合計値を算出する。この値は円グラフにプロットする比率の計算に使用する。
            double sum = Convert.ToDouble(Table.Compute("Sum(Value)", null));

            long maxSize = 0; //←凡例に出力する文字列で最も長い値を格納する。この値は凡例の幅の設定に用いる。
            long sumRowHeight = 0;//←凡例に出力する文字列の高さの合計を格納する。この値は凡例の高さの設定に用いる。
            long othersTime = 0; //Value列の値の上位10位より下の項目の合計値を格納する。この値は「その他」項目の計算用の計算に用いる。

            for (int i1 = 0; i1 < Rows.Count() - 1; i1++)
            {
                if (i1 < 10)
                {

                    //グラフへプロットする比率を計算する。
                    //※四捨五入の誤差の影響で出力した比率の合計が100％にならないことがあります。その旨は操作画面上などで説明するか別途対策を行う必要があると思います。
                    double rate = Math.Round(Convert.ToDouble(Rows[i1][2]) / sum, 3, MidpointRounding.AwayFromZero) * 100;

                    //項グラフへプロットする項目名を取得する。項目名が20文字以上の場合は先頭の20文字とする。
                    string itemName = (Rows[i1][1].ToString().Length > 20) ? Rows[i1][1].ToString().Substring(0, 20) : Rows[i1][1].ToString();

                    //グラフにデータをプロットする。
                    System.Windows.Forms.DataVisualization.Charting.DataPoint dp = new System.Windows.Forms.DataVisualization.Charting.DataPoint();
                    dp.SetValueXY(itemName, rate);
                    chart1.Series["Series1"].Points.Add(dp);

                    //凡例のサイズ計算を行う。
                    maxSize = Math.Max(maxSize, TextRenderer.MeasureText(itemName, this.chart1.Legends["Legend1"].Font).Width);
                    sumRowHeight += TextRenderer.MeasureText(itemName, this.chart1.Legends["Legend1"].Font).Height;

                }
                else
                {

                    //上位10位より下の項目の合計値をまとめる。
                    othersTime += Convert.ToInt32(Rows[i1][2]);

                }

            }

            //Value列の値の上位10位より下の項目の合計値は「その他」としてまとめて表示する。
            if (othersTime > 0)
            {

                //凡例のサイズ計算を行う。
                maxSize = Math.Max(maxSize, TextRenderer.MeasureText("その他", this.chart1.Legends["Legend1"].Font).Width);
                sumRowHeight += TextRenderer.MeasureText("その他", this.chart1.Legends["Legend1"].Font).Height;

                //グラフにデータをプロットする。
                double othersRate = Math.Round(othersTime / sum, 3, MidpointRounding.AwayFromZero) * 100;
                System.Windows.Forms.DataVisualization.Charting.DataPoint dp = new System.Windows.Forms.DataVisualization.Charting.DataPoint();
                dp.SetValueXY("その他", othersRate);
                chart1.Series["Series1"].Points.Add(dp);

            }

            //凡例の幅と高さを設定する。chart外枠との比率を設定する。
            float width = (float)(maxSize + 100) / (float)this.chart1.Width * 100; //余白と色箇所分として100をプラスしている。単位を%にするため100を乗ずる。
            float height = (float)(sumRowHeight + 40) / (float)this.chart1.Height * 100; //※余白分で40をプラスしている。単位を%にするため100を乗ずる。

            this.chart1.Legends["Legend1"].Position.Width = width;
            this.chart1.Legends["Legend1"].Position.Height = height;
        }
        
    }
}
