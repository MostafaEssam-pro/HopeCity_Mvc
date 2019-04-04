using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace view_eye.Models
{
    public class Answers
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Ansr_text { get; set; }

        [ForeignKey("Questions")]
        public int Questions_Id { get; set; }
        public Questions Questions { get; set; }
        public virtual List<Test> tests { get; set; }
    }
}