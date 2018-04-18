using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows.Forms;


namespace myPuzzle
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            InitGame();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }


        //图片列表
        PictureBox[] pictureList = null;
        //图片位置字典
        SortedDictionary<string, Bitmap> pictureLocationDict = new SortedDictionary<string, Bitmap>();
        //Location List
        Point[] pointList = null;
        //图片控制字典
        SortedDictionary<string, PictureBox> pictureBoxLocationDict = new SortedDictionary<string, PictureBox>();
        //拼图时间
        int second = 0;
        //所拖拽的图片
        PictureBox currentPictureBox = null;
        //逼迫所需要移动的图片
        PictureBox haveToPictureBox = null;
        //原位置
        Point oldLocation = Point.Empty;
        //新位置
        Point newLocation = Point.Empty;
        //鼠标按下坐标（control控件的相对坐标）
        Point mouseDownPoint = Point.Empty;
        //显示拖动效果的矩形
        Rectangle rect = Rectangle.Empty;


        //是否正在拖拽
        bool isDrag = false;

        //图片位置
        public string originalpicpath;


        /*
         每个方向上要切割成的块数
         */
        private int ImgNumbers { get
            {
                if ((int)this.numericUpDown1.Value <0)
                {
                    MessageBox.Show("无效的分块数目", "错误", MessageBoxButtons.OK);
                    MessageBox.Show("从最简单的难度开始吧！", "提示", MessageBoxButtons.OK);
                    numericUpDown1.Value = 1;
                }
              
                  return (int)this.numericUpDown1.Value+1;
            }

        }


        //要割成的正方形图形边长
        private int SideLength { get{ return 600 / this.ImgNumbers; } }


        //预先设置图片的矩阵大小（默认3*3），在在主窗体上动态生成图片框矩阵，并初始化每个图片框的位置后放在pnl_Picture控件上
        private void initRandomPictureBox()
        {
            pnl_Picture.Controls.Clear();
            pictureList = new PictureBox[ImgNumbers * ImgNumbers];
            pointList = new Point[ImgNumbers * ImgNumbers];
            for (int i = 0; i < this.ImgNumbers; i++)
            {
                for (int j = 0; j < this.ImgNumbers; j++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Name = "pictureBox" + (j + i * ImgNumbers + 1).ToString();
                    pic.Location = new Point(j * SideLength, i * SideLength);
                    pic.Size = new Size(SideLength, SideLength);
                    pic.Visible = true;
                    pic.BorderStyle = BorderStyle.FixedSingle;
                    pic.MouseDown += new MouseEventHandler(pictureBox_MouseDown);
                    pic.MouseMove += new MouseEventHandler(pictureBox_MouseMove);
                    pic.MouseUp += new MouseEventHandler(pictureBox_MouseUp);
                    pnl_Picture.Controls.Add(pic);
                    pictureList[j + i * ImgNumbers] = pic;
                    //图片切割后按从左到右，从上到下顺序放入一维数组
                    pointList[j + i * ImgNumbers] = new Point(j * SideLength, i * SideLength);
                }
            }
        }

        //将图片切割成与图片框矩阵大小，数量相同的图片矩阵，并保存在CutPicture，BitMapList中。然后调用PortBitMap方法，把图片加载到图片框矩阵中
        public void Flow(string path, bool disorder)
        {
            initRandomPictureBox();
            Image bm = CutPicture.Reszie(path, 600, 600);
            CutPicture.BitMapList = new List<Bitmap>();
            for (int y = 0; y < 600; y += SideLength)
            {
                for (int x = 0; x < 600; x += SideLength)
                {
                    Bitmap temp = CutPicture.Cut(bm,x,y,SideLength,SideLength);
                    CutPicture.BitMapList.Add(temp);
                }
            }
            ImportBitMap(disorder);

        }


        /// 计时
       public void CountTime()
        {
            lab_time.Text = "0";
            timer1.Start();
        }
        

        /// 打乱位置列表

        public Point[] DisOrderLocation()
        {
            Point[] tempArray = (Point[])pointList.Clone();
            for (int i = tempArray.Length - 1; i > 0; i--)
            {
                Random rand = new Random();
                int p = rand.Next(i);
                Point temp = tempArray[p];
                tempArray[p] = tempArray[i];
                tempArray[i] = temp;
            }
            return tempArray;
        }
        /// 重新设置图片位置

        public void ResetPictureLocation()
        {
            Point[] temp = DisOrderLocation();
            int i = 0;
            foreach (PictureBox item in pictureList)
            {
                item.Location = temp[i];
                i++;
            }
        }
        public void ImportBitMap(bool disorder)
        {
            try
            {
                int i = 0;
                foreach (PictureBox item in pictureList)
                {
                    Bitmap temp = CutPicture.BitMapList[i];
                    item.Image = temp;
                    i++;
                }
                if (disorder)
                    ResetPictureLocation();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
         }


        //调用从软件自身携带的图片资源中随机选择一张，然后调用Flow函数实现游戏资源的初始化工作
        public void InitGame()
        {

            if (!Directory.Exists(Application.StartupPath.ToString() + "\\Picture"))
            {
                Directory.CreateDirectory(Application.StartupPath.ToString() + "\\Picture");
                Properties.Resources._0.Save(Application.StartupPath.ToString() + "\\Picture\\0.jpg");
                Properties.Resources._1.Save(Application.StartupPath.ToString() + "\\Picture\\1.jpg");
                Properties.Resources._2.Save(Application.StartupPath.ToString() + "\\Picture\\2.jpg");
                Properties.Resources._3.Save(Application.StartupPath.ToString() + "\\Picture\\3.jpg");
                Properties.Resources._4.Save(Application.StartupPath.ToString() + "\\Picture\\4.jpg");
                Properties.Resources._5.Save(Application.StartupPath.ToString() + "\\Picture\\5.jpg");
            }
            Random r = new Random();
            int i = r.Next(6);
            originalpicpath = Application.StartupPath.ToString() + "\\Picture\\" + i.ToString() + ".jpg";
            Flow(originalpicpath, true);

        }

        //便于鼠标拖拽过程中根据图片获取图片框的位置
        public PictureBox GetPictureBoxByLocation(int x, int y)
        {
            PictureBox pic = null;
            foreach (PictureBox item in pictureList)
            {
                if (x > item.Location.X && y > item.Location.Y && item.Location.X + SideLength > x && item.Location.Y + SideLength > y)
                {
                    pic = item;
                }
            }
            return pic;
        }




        //为释放鼠标添加操作事件

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            oldLocation = new Point(currentPictureBox.Location.X, currentPictureBox.Location.Y);
            if(oldLocation.X+e.X>600||oldLocation .Y+e.Y>600||oldLocation.X+e.X<0||oldLocation.Y+e.Y<0)
            {
                return;
            }
            haveToPictureBox = GetPictureBoxByLocation(oldLocation.X + e.X, oldLocation.Y + e.Y);
            newLocation = new Point(haveToPictureBox.Location.X, haveToPictureBox.Location.Y);
            haveToPictureBox.Location = oldLocation;
            PictureMouseUp(currentPictureBox,sender, e);
            if (Judge())
            {
                //lab_result.Text = "成功！！";
                MessageBox.Show("恭喜拼图成功！","提示");
                InitGame();
            }
        }
        public void PictureMouseUp(PictureBox pic, object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (isDrag)
                {
                    isDrag = false;
                    pic.Location = newLocation;
                    this.Refresh();
                }
                reset();
            }

        }

        // //主窗体上动态添加的图片框添加“按下鼠标键”操作事件
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            oldLocation = new Point(e.X, e.Y);
            currentPictureBox = GetPictureBoxByHashCode(sender.GetHashCode().ToString());
            MoseDown(currentPictureBox, sender, e);
        }
        public void MoseDown(PictureBox pic, object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                oldLocation = e.Location;
                rect = pic.Bounds;
            }

        }

        public PictureBox GetPictureBoxByHashCode(string hascode)
        {
            PictureBox pic = null;
            foreach (PictureBox item in pictureList)
            {
                if (hascode == item.GetHashCode().ToString())
                {
                    pic = item;
                }
            }
            return pic;
        }


        private Point getPointToForm(Point p)
        {
            return this.PointToClient(pnl_Picture.PointToScreen(p));//改动
        }

        //移动鼠标操作事件
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrag = true;
                rect.Location = getPointToForm(new Point(e.Location.X - oldLocation.X, e.Location.Y - oldLocation.Y));
                //MessageBox.Show(rect.Location.Tostring());
                this.Refresh();
            }
        }
        private void reset()
        {
            mouseDownPoint = Point.Empty;
            rect = Rectangle.Empty;
            isDrag = false;
        }


        //判断拼图是否成功
        public bool Judge()
        {
            bool result = true;
            int i = 0;
            foreach (PictureBox item in pictureList)
            {
                if (item.Location != pointList[i])
                {
                    result = false;
                }
                i++;
            }
            return result;
        }
        //试玩新图按钮
        private void btn_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog newPic = new OpenFileDialog();
            if (newPic.ShowDialog() == DialogResult.OK)
            {
                //lab_result.Text = "";
                originalpicpath= newPic.FileName;
                CutPicture.PicturePath = newPic.FileName;
                Flow(CutPicture.PicturePath, true);
                //CountTime();
            }
        }
        //切换图片
        private void btn_Changepic_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int i = r.Next(6);
            originalpicpath = Application.StartupPath.ToString()+"\\Picture\\"+i.ToString()+".jpg";
            Flow(originalpicpath, true);
        }


        //图片重排
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Flow(originalpicpath, true);
        }


        //查看原图
        private void btn_Originalpic_Click(object sender, EventArgs e)
        {
            Form_Original original = new Form_Original();
            original.picpath = originalpicpath;
            original.Show();
        }

        private void lab_time_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void t_Tick(object sender, EventArgs e)
        {
            second++;
            btn_select.Visible = true;
            lab1.Text = "挑战时间（30s）:";
            lab_time.Text = second.ToString();
            lab2.Text = "s";
            if (Judge()) {
                timer1.Stop();
                lab_time.Text = "";
                btn_select.Visible = false;
                lab1.Text = "";
                lab_time.Text = "";
                lab2.Text = "";
                second = 0;
                //DialogResult ans = MessageBox.Show("是否重新挑战？", "提示", MessageBoxButtons.RetryCancel);
            }
            else
                if (second == 30)
              {  
                timer1.Stop();
                MessageBox.Show("挑战失败！", "O(∩_∩)O哈哈", MessageBoxButtons.OK);
                DialogResult ans = MessageBox.Show("是否重新挑战？", "提示", MessageBoxButtons.RetryCancel);
                if (ans == DialogResult.Retry)
                {
                    lab_time.Text = "";
                    second = 0;
                    InitGame();
                    timer1.Start();
                }
                else
                {
                    second = 0;
                    lab_time.Text = "";
                    btn_select.Visible = false;
                    lab1.Text = "";
                    lab_time.Text = "";
                    lab2.Text = "";
                    InitGame();
                }
                
            }

        }


        //挑战模式
        private void btn_challenge_Click(object sender, EventArgs e)
        {
            // lab_result.Text = "";
            DialogResult ans = MessageBox.Show("请选择难度等级", "提示", MessageBoxButtons.OKCancel);
            if (ans == DialogResult.OK)
            {
                sel_level pp = new sel_level();
                pp.ShowDialog();
                this.numericUpDown1.Value = Select_level.sLevel;
                Flow(originalpicpath, true);
                timer1.Start();
            }
            /*else {
                //MessageBox.
                InitGame();
            }*/
            
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DialogResult ans = MessageBox.Show("是否要结束此次挑战？", "提示", MessageBoxButtons.OKCancel);         
            if (ans == DialogResult.OK)
            {
               
                second = 0;
                lab_time.Text = "";
                btn_select.Visible = false;
                lab1.Text = "";
                lab_time.Text = "";
                lab2.Text = "";
                InitGame();
            }
            else {
                timer1.Start();
            }
        }

        private void lab_result_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    

}
