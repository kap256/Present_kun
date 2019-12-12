using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Present_kun
{
    public partial class Form1 : Form
    {
        int ResultId = -1;
        List<int> Results = null;

        public Form1()
        {
            InitializeComponent();
        }

        //リストに名前を追加します。
        private void button_AddName_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(text_AddName.Text)) {
                list_Names.Items.Add(text_AddName.Text);
                text_AddName.Text = "";
            }
        }

        //リストから名前を削除します。
        private void list_Names_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            list_Names.Items.Remove(list_Names.SelectedItem);
        }

        //結果表示をします。
        private void button_Result_Click(object sender, EventArgs e)
        {
            //初回実行時
            if (Results == null) {
                if (list_Names.Items.Count < 2) {
                    return;
                }
                list_Names.Enabled = false;
                text_AddName.Enabled = false;
                button_AddName.Enabled = false;
                label_Result.Text = "";
                AcceptButton = button_Result;

                CreateNewResult();
            }

            //結果の順次表示
            label_Result.Text += 
                list_Names.Items[ResultId] 
                + " => "
                + list_Names.Items[Results[ResultId]]
                + Environment.NewLine;

            ResultId++;


            //最後まで表示が終わった時
            if (ResultId>= Results.Count) {
                list_Names.Enabled = true;
                text_AddName.Enabled = true;
                button_AddName.Enabled = true;
                AcceptButton = button_AddName;

                Results = null;
            }

        }

        //結果作成
        private void CreateNewResult()
        {
            var rand = new Random();

            do {
                Results = new List<int>();
                var values = new List<int>();
                for (int i =0;i< list_Names.Items.Count; i++) {
                    values.Add(i);
                }
                
                while(values.Count>0) {
                    int index = rand.Next(values.Count);
                    int val = values[index];
                    values.RemoveAt(index);
                    Results.Add(val);
                    if(Results.Count == val +1) {  //完全順列じゃなければやり直し
                        Results = null;
                        break;
                    }
                }
            } while (Results==null);

            ResultId = 0;
        }

    }
}
