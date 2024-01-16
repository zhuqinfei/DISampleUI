using DISampleBLL;
using DISampleDAL;
using DISampleISkirtBLL;
using DISampleISkirtDAL;
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
            ISkirtDAL skirtDAL = new SkirtDAL();
            ISkirtBLL skirtBLL = new SkirtBLL(skirtDAL);
            List<Skirt> skirts = skirtBLL.GetSkirts();

            foreach (Skirt s in skirts)
            {
                Console.WriteLine(s.Name);
            }
        }
        //什么是依赖注入
        //UI---->>BLL---->>DAL(三层架构)(Model)
        //UI---->>BLL(具体的一个类，在用的时候需要New，它是个具体业务实现片
        //UI---->>引用抽象或者接口(面向接口编程，面向抽象编程)IBLL(ABLL)
        //UI---->>IBLL(ABLL)---->>IDAL(ADAL)
        //谁来继承抽象?具体业务实现，BLL继承IBLL，DAL继承IDAL

    }
}
