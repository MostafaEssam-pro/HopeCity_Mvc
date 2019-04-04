using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace view_eye.Models
{
    public class Questions  
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Text_Qus { get; set; }

        [ForeignKey("Categorys")]
        public virtual int Categorys_Id { get; set; }
        public virtual Categorys Categorys { get; set; }


        public List<Answers> Answers { get; set; }
    }
}