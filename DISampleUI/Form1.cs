using DISampleBLL;
using DISampleModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DISampleUI
{
    /// <summary>
    /// UI界面
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        /// <summary>
        /// 单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BnDISampleUI_Click(object sender, EventArgs e)
        {
            SkirtBLL skirtBLL = new SkirtBLL();
            List<Skirt> skirts = skirtBLL.GetSkirts();

            foreach (Skirt s in skirts)
            {
                Console.WriteLine(s.Name);
            }
        }
        //什么是依赖注入
        //UI---->>BLL---->>DAL(三层架构)(Model)
        
    }
}
