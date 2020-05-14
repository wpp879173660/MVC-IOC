using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using IDAL;
namespace DAL
{
   public class dala:IDisposable,ia
    {
        SYEntities db = new SYEntities();
        public List<a> getall()
        {
            return db.a.ToList();
        }

        public int add(a aa)  {
            db.a.Add(aa);
            return db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
        //private string 女朋友() {
        //    return 女人;
        //}

       
    }
}
