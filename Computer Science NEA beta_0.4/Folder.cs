using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Computer_Science_BETA_0._3
{
    internal class Folder
    {
        public int userid {  get; set; }
        public int folderid {  get; set; }
        public string foldername { get; set; }
        public string foldertype { get; set; }
        public List<string> tags { get; set; }
        public double score { get; set; }
        public int veryeasy_count { get; set; }
        public int easy_count {  get; set; }
        public int okay_count {  get; set; }
        public int difficult_count {  get; set; }
        public int verydifficult_count { get; set; }
        public Folder()
        {
            tags = new List<string>();
        }

        public Folder(int userid, int folderid, string foldername, string foldertype, List<string> tags)
        {
            this.userid = userid;
            this.folderid = folderid;
            this.foldername = foldername;
            this.foldertype = foldertype;
            this.tags = tags;
        }

        public Folder (int veryeasy_count, int easy_count, int okay_count, int difficult_count, int verydifficult_count)
        {
            this.veryeasy_count = veryeasy_count;
            this.easy_count = easy_count;
            this.okay_count = okay_count;
            this.difficult_count = difficult_count;
            this.verydifficult_count = verydifficult_count;
        }
    }

   
}
