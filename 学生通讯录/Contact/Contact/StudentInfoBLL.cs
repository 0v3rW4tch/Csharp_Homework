using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;


namespace Contact
{
    public class StudentInfoBLL
    {
        //xml文件路径
        public static string _basePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/xml/Students.xml";
        private static string _basePath2 = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/xml/Students2.xml";
        private static string Path3 = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/xml/Count.txt";
     //   private static int count;
        //创建学生文档
        public static void CreatStudentXml()
        {
            XDocument studentDoc = new XDocument();
            //创建XML文档

            XDeclaration xDeclaration = new XDeclaration("1.0","utf-8","yes");
            //声明   

            studentDoc.Declaration = xDeclaration;

            //创建studentstore节点  书本上好像说这里这一句不能放在第一句话，因为xml中第一句话是声明
            XElement xElement = new XElement("students");

            //保存文件
            studentDoc.Add(xElement);
            studentDoc.Save(_basePath);//这里每一部分差不多都有


        }
        
       
        //增加学生信息
        public static bool AddStudentInfo(StudentInfo param)
        {
            int count;
            XElement xml = XElement.Load(_basePath);
            //创建student节点

            if (GetAllStudentInfo() == null)
            {
                string str1 = File.ReadAllText(Path3);
                if (Int32.Parse(str1) == 1)
                    count = 1;
                else
                    count = Int32.Parse(str1)+1;
            }
            else
            {
                string str2 = File.ReadAllText(Path3);
                count = Int32.Parse(str2)+1;

            }

           
                XElement studentXml = new XElement("student");
                //添加属性
                param.StudentKey = count;
                //添加子节点
                studentXml.Add(new XElement("studentid", param.StudentId));
                studentXml.Add(new XAttribute("studentkey", param.StudentKey));
                studentXml.Add(new XElement("name", param.Name));
                studentXml.Add(new XElement("sex", param.Sex));
                studentXml.Add(new XElement("age", param.Age.ToString()));
                studentXml.Add(new XElement("birthdate", param.BirthDate.ToString("yyyy-MM-dd")));
                studentXml.Add(new XElement("phone", param.Phone));
                studentXml.Add(new XElement("homeaddress", param.HomeAddress));
                studentXml.Add(new XElement("email", param.Email));
                string a = param.Email;
                if (!CheckBadStr(a))
                {
                    MessageBox.Show("email格式错误，请重新输入！", "错误", MessageBoxButtons.OK);
                    return false;
                }
                studentXml.Add(new XElement("profession", param.Profession));

                xml.Add(studentXml);
                //把txt清空
                FileStream stream = File.Open(Path3, FileMode.OpenOrCreate, FileAccess.Write);
                stream.Seek(0, SeekOrigin.Begin);
                stream.SetLength(0);
                stream.Close();
                //向txt里面追加信息
                StreamWriter sw = new StreamWriter(Path3, true, Encoding.GetEncoding("utf-8"));
                sw.WriteLine(count);
                sw.Flush();
                sw.Close();
                xml.Save(_basePath);

          


            return true;
        }




        //修改学生信息
        public static bool UpdateStudentInfo(StudentInfo param)
        {
            bool result = false;
           
                if (param.StudentKey > 0)
                {
                    //根据 key 找到要修改的学生的XML
                    XElement xml = XElement.Load(_basePath);//载入文件
                    XElement studentXml = (from db in xml.Descendants("student")
                                           where db.Attribute("studentkey").Value == param.StudentKey.ToString()
                                           select db).Single();

                    //修改子节点
                    studentXml.SetElementValue("studentid", param.StudentId);
                    studentXml.SetElementValue("name", param.Name);
                    studentXml.SetElementValue("sex", param.Sex);
                    studentXml.SetElementValue("age", param.Age.ToString());
                    studentXml.SetElementValue("birthdate", param.BirthDate.ToString("yyyy- MM- dd"));
                    studentXml.SetElementValue("phone", param.Phone);
                    studentXml.SetElementValue("email", param.Email);
                    string a = param.Email;
                    if (!CheckBadStr(a))
                    {
                        MessageBox.Show("email格式错误，请重新输入！", "错误", MessageBoxButtons.OK);
                        return result;
                    }
                    studentXml.SetElementValue("homeaddress", param.HomeAddress);
                    studentXml.SetElementValue("profession", param.Profession);


                    //保存
                    xml.Save(_basePath);
                    result = true;
                }
                return result;
            
          

        }

        //删除学生信息
        public static bool DeleteStudentInfo(int studentkey)
        {
           // int count;
            bool result = false;
            if (studentkey > 0)//确保里边有信息
            {
                XElement xml = XElement.Load(_basePath);
                XElement studentXml = (from db in xml.Descendants("student")
                                       where db.Attribute("studentkey").Value == studentkey.ToString()
                                       select db).Single();
                studentXml.Remove();
                xml.Save(_basePath);
                result = true;
            }

            //BackupStudentXml();
            return result;

        }



        //查询全部学生信息
        /*
         这里是直接运用C#里边的列表然后去返回一个列表信息
         */
        public static List<StudentInfo> GetAllStudentInfo()
        {
            List<StudentInfo> studentList = new List<StudentInfo> ();
            XElement xml = XElement.Load(_basePath);

            var studentVar = xml.Descendants("student");//默认查询所有信息

            
             studentList = (from student in studentVar select new StudentInfo
                                          {
                                              StudentKey = Int32.Parse(student.Attribute("studentkey").Value),
                                              StudentId = Int32.Parse(student.Element("studentid").Value),
                                              Name = student.Element("name").Value,
                                              Age = Int32.Parse(student.Element("age").Value),
                                              Sex = student.Element("sex").Value,
                                              BirthDate = DateTime.Parse(student.Element("birthdate").Value),
                                              Phone = student.Element("phone").Value,
                                              HomeAddress = student.Element("homeaddress").Value,
                                              Email = student.Element("email").Value,
                                              Profession = student.Element("profession").Value
                                          }).ToList();
            return studentList;
        }


        //根据学号查询学生信息
        public static StudentInfo GetStudentInfo(int studentid)
        {
            StudentInfo studentinfo = new StudentInfo();
            XElement xml = XElement.Load(_basePath);
            studentinfo = (from student in xml.Descendants("student") where student.Element("studentid").Value == studentid.ToString()
                           select new StudentInfo
                           {
                               StudentKey = Int32.Parse(student.Attribute("studentkey").Value),
                               StudentId = Int32.Parse(student.Element("studentid").Value),
                               Name = student.Element("name").Value,
                               Age = Int32.Parse(student.Element("age").Value),
                               Sex = student.Element("sex").Value,
                               BirthDate = DateTime.Parse(student.Element("birthdate").Value),
                               Phone = student.Element("phone").Value,
                               HomeAddress = student.Element("homeaddress").Value,
                               Email = student.Element("email").Value,
                               Profession = student.Element("profession").Value
                           }).Single();
            return studentinfo;
        }

        //查找学生ID
   public static bool SearchStudentInfo(int studentid)
        {
            XElement xml = XElement.Load(_basePath);
            XElement studentXml = (from db in xml.Descendants("student") where db.Element("studentid").Value == studentid.ToString() select db).Single();
            if (studentXml == null)
                return false;
            else
                return true;
        }
 

        //根据主键查询学生信息
        public static StudentInfo GetStudentInfo2(int studentkey)
        {
            StudentInfo studentinfo = new StudentInfo();
            XElement xml = XElement.Load(_basePath);
           studentinfo = (from student in xml.Descendants("student") where student.Attribute("studentkey").Value == studentkey.ToString ()
                           select new StudentInfo
                           {
                               StudentKey = Int32.Parse(student.Attribute("studentkey").Value),
                               StudentId = Int32.Parse(student.Element("studentid").Value),
                               Name = student.Element("name").Value,
                               Age = Int32.Parse(student.Element("age").Value),
                               Sex = student.Element("sex").Value,
                               BirthDate = DateTime.Parse(student.Element("birthdate").Value),
                               Phone = student.Element("phone").Value,
                               HomeAddress = student.Element("homeaddress").Value,
                               Email = student.Element("email").Value,
                               Profession = student.Element("profession").Value
                           }).Single();
            return studentinfo;
        }

        //查询列表

        public static List<StudentInfo> GetStudentInfoList(StudentInfo param)
        {
            List<StudentInfo> studentList = new List<StudentInfo> ();
            XElement xml = XElement.Load(_basePath);
            var studentVar = xml.Descendants("student");//默认查询所有学生

            if (param.StudentId > 0)//根据ID查学生
            {
                studentVar = xml.Descendants("student").Where(a => a.Element("studentid").Value == param.StudentId.ToString());

            }
            else if (!String.IsNullOrEmpty(param.Name))//根据学生名字查询
            {
                studentVar = xml.Descendants("student").Where(a => a.Element("name").Value == param.Name);
            }
            else if (!String.IsNullOrEmpty(param.Sex))
            {
                studentVar = xml.Descendants("student").Where(a => a.Element("sex").Value == param.Sex);
            }
            else if (!String.IsNullOrEmpty(param.Profession))
            {
                studentVar = xml.Descendants("student").Where(a => a.Element("profession").Value == param.Profession);
            }
            studentList = (from student in studentVar
                           select new StudentInfo
                           {
                               StudentKey = Int32.Parse(student.Attribute("studentkey").Value),
                               StudentId = Int32.Parse(student.Element("studentid").Value),
                               Name = student.Element("name").Value,
                               Age = Int32.Parse(student.Element("age").Value),
                               Sex = student.Element("sex").Value,
                               BirthDate = DateTime.Parse(student.Element("birthdate").Value),
                               Phone = student.Element("phone").Value,
                               HomeAddress = student.Element("homeaddress").Value,
                               Email = student.Element("email").Value,
                               Profession = student.Element("profession").Value
                           }).ToList();
            return studentList;

        }
        //备份
        public static void BackupStudentXml()
        {


            bool bSuccess = true;
            while (bSuccess)
            {
                string strTaskListPath = _basePath2;
                XmlDocument xmlDocd = new XmlDocument();
                xmlDocd.Load(strTaskListPath);
                XmlNodeList xnl = xmlDocd.SelectSingleNode("students").ChildNodes;
                int nCount = xnl.Count;
                if (0 == nCount)
                {
                    bSuccess = false;
                }
                for (int i = 0; i < xnl.Count; i++)
                {
                    xnl[i].ParentNode.RemoveChild(xnl[i]);
                }
                xmlDocd.Save(strTaskListPath);
            }

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(_basePath);//得加个根节点(XML只能包含一个根节点)
            XmlDocument xmlDoc2 = new XmlDocument();
            xmlDoc2.Load(_basePath2);
            foreach (XmlNode item in xmlDoc.DocumentElement)
            {
                xmlDoc2.DocumentElement.SelectSingleNode("//students").AppendChild(xmlDoc2.ImportNode(item, true));
            }

            xmlDoc2.Save(_basePath2);
            //MessageBox.Show("备份成功！"); 
        }
        //恢复
        public static void RecoveryStudentXml()
        {
            
            bool bSuccess = true;
            while (bSuccess)
            {
                string strTaskListPath = _basePath;
                XmlDocument xmlDocd = new XmlDocument();
                xmlDocd.Load(strTaskListPath);
                XmlNodeList xnl = xmlDocd.SelectSingleNode("students").ChildNodes;
                int nCount = xnl.Count;
                if (0 == nCount)
                {
                    bSuccess = false;
                }
                for (int i = 0; i < xnl.Count; i++)
                {
                    xnl[i].ParentNode.RemoveChild(xnl[i]);
                }
                xmlDocd.Save(strTaskListPath);
            }

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(_basePath);//得加个根节点(XML只能包含一个根节点)
            XmlDocument xmlDoc2 = new XmlDocument();
            xmlDoc2.Load(_basePath2);
            foreach (XmlNode item in xmlDoc2.DocumentElement)
            {
                xmlDoc.DocumentElement.SelectSingleNode("//students").AppendChild(xmlDoc.ImportNode(item, true));
            }

            xmlDoc.Save(_basePath);
            MessageBox.Show("恢复成功！");
        }


        public static bool CheckBadStr(string strString)
        {
            bool outValue = false;
            if (strString != null && strString.Length > 0)
            {
                string[] bidStrlist = new string[10];
                bidStrlist[0] = "@qq.com";
                bidStrlist[1] = "@163.com";
                bidStrlist[2] = "@msn.com";
                bidStrlist[3] = "@sohu.com";
                bidStrlist[4] = "@cumt.edu.cn";
                bidStrlist[5] = "@hotmail.com";
                bidStrlist[6] = "@163.net";
                bidStrlist[7] = "@126.com";
                bidStrlist[8] = "@yahoo.com";
                bidStrlist[9] = "@sina.com";


                string tempStr = strString.ToLower();
                for (int i = 0; i < bidStrlist.Length; i++)
                {
                    if (tempStr.IndexOf(bidStrlist[i]) != -1)
                    //if (tempStr == bidStrlist[i])    
                    {
                        outValue = true;
                        break;
                    }
                }
               // if(outValue == false)

            }
            return outValue;
        }





    }
}
