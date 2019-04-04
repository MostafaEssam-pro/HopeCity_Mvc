using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace view_eye.Models
{
    public class Test
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Doctors")]
        public virtual int Doctors_Id { get; set; }
        public virtual Doctors Doctors { get; set; }
        [ForeignKey("Patients")]
        public virtual int Patients_Id { get; set; }
        public virtual Patients Patients { get; set; }
        [ForeignKey("Answers")]
        public virtual int AnswersId { get; set; }
        public virtual Answers Answers { get; set; }
    }
}