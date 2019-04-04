using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace view_eye.Models
{
    public class Patients
    {

        /// <summary>
        /// /// استمارة بيانات اولية
        /// </summary>
        /// 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } //1


        
        public string FullName { get; set; }//الاسم الثلاثي1

        
        public string Gender { get; set; }//النوع 2

        
        public string BirthDate { get; set; }//تاريخ الميلاد3

        
        public string Age { get; set; }//4السن

        
        public string Date { get; set; }//تاريخ الاختبار5

        
        public string Nationality { get; set; }//الخنسيه6

        public int? NumberofSpling { get; set; }  // عدد الاخوة7

        
        public string NameOfaSpling { get; set; }// 8و اسمائهم


        
        public string Thechildorder { get; set; }//موقع الطفل بين الاخوات9


        
        public string Placeofresidence { get; set; }//محل الاقامة10


        
        public string Fatheroccupation { get; set; }//وظيفه الاب11 


        
        public string Educationalqualification { get; set; }//المؤهل الدراسي 12

        public int? Home_number_Fa { get; set; }//رقم تليفون المنزل بتاع الاب 13
        public int? Mobile_Fa { get; set; }//رقم الموبيل بتاع الاب 14


        
        public string Mother_name { get; set; }//اسم الام 15
        
        public string MotherWork { get; set; }//وظيفة الام16
        
        public string EducationMother { get; set; }//17وظيفه الام

        public int? Home_number_Mo { get; set; }//رقم تليفون المنزل بتاع الام 18
        public int? Mobile_Mo { get; set; }//رقم الموبيل بتاع الام 19

        
        public string Referral_source { get; set; }//20مصد الحالة

        
        public string Where_Live_Child { get; set; }//21مع من يقيم الطفل 

        
        public string Name_Live_chiled { get; set; }//22 المقيم

        
        public string Sponsored_Child { get; set; }//23 من القائم برعايه الطفل 

        public bool? RelatedOfFamily { get; set; } //هل توجد صلة قرابة بين الاب و الام////24

        
        public string Describe_Relationship { get; set; }//25اوصف صلة القرابة
        public bool? TheSameInFamily { get; set; }//هل توجد حالات مشابهة فى الاسرة//26
        
        public string RelationShip { get; set; }//ان كانت الاجابة بنعم فما درجة القرابة//27

        
        public string Parental_complaint { get; set; }//28شكوي الاهل



        //////////////
        ///بيانات فترة الحمل
        ///

        public int? Pregnancy_Time { get; set; }//1-29ماهي مدة الحمل ؟

        public bool? DiseasesduringPregnancy { get; set; }//2-30 هل كانت الام تعاني من اي امراض اثناء الحمل
        public bool? InfectioOrVirus { get; set; }//3-31هل اصيبت الام باي عدوي اوفيروس الانفلونز-الهريس-الحصبة -الخ

        
        public string TypeOfVirus { get; set; }//4-32ان كانت الاجابه فما نوع هذه العدوي او الفيروس
        public bool? Abdominal_Injury { get; set; }//5-33هل اصيبت الام باي اصابه مباشره في البطن ؟ 
        public bool? Exposed_Radiation { get; set; }//6-34هل تعرضت الام للاشعاع ؟
        public bool? Take_Drugs { get; set; }//7-35هل تعاطت الام العقاقير ؟
        
        public string Name_Drugs { get; set; }//8-36اذا الاجابه بعم فما اسم العقار؟ وما السبب تناوله ؟ وما مدة تناولة
        public bool? Smoke { get; set; }//9-37 هل كانت الام تدخن او تتعاطي اي نوع من المكيفات ؟
        
        public string Type_Smoke { get; set; }//10-38اذا كانت الاجابه نعم فما هو نوع هذه المكيفات

        //بيانات عن الولادة

        public bool? Natural_Birth { get; set; }//11-39هل كانت الولاده طبيعية 
        public bool? Birth_Difficult { get; set; }//12-40 هل كانت الولادة متعثرة ؟
        public bool? Tools_Birth { get; set; }//13-41هل تم استخدم ادوات مثل الجفت الشفاط اثناء الولادة 
        public bool? Problems_Child_OX { get; set; }//14-42هل يعاني الطفل من اي مشاكل في التنفس ونقص الاكسجين ؟

        //بيانات بعد الولادة

        public int? Child_Weight { get; set; }//15-43ما هو وزن الطفل عند الولادة؟

        public bool? Incubator { get; set; }//16_44هل تم وضع الطفل في حضانة بعد الولادة ؟


        
        public string ReasonN { get; set; }//17-45 اذا كانت الاجابة بعم فما سبب وضعة في حضانة؟ وما المدة ؟

        // الامراض الذى يعانى منها

        public bool? Diseases_Chlid { get; set; }//18_46هل يعاني الطفل من اي امراض او عيوب خلقية

        
        public string Congenital { get; set; }//19-47اذا كانت الاجابة بعم فما هي هذة الامراض والعيوب الخلقية ؟
        public bool? Breastfeeded { get; set; }//20-48هل اصيب الطفل بالصفراء ؟
        
        public string Reasonbreastfeeded { get; set; }//21-49اذا كانت الاجابة بعم فما هي درجتها ؟
        public bool? NAUral { get; set; }//22-50هل كانت رضاعة الطفل طبيعية
        
        public string OfReason { get; set; }//23-51 اذا كانت الاجابة لا فما السبب

        //----------------------------------------------------------///
        public bool? Swallowing { get; set; }//1-52 هل يعاني الطفل من صعوبة في البلع ؟
        public bool? Directtrauma { get; set; }//2-53 هل اصيب الطفل باي اصابة ؟
        public bool? Acute { get; set; }//3-54 هل اصيب الطفل باي عدوي حادة ؟
        
        public string Type_Acute { get; set; }//4-55 اذا كانت الاجابة نعم فما هو نوع العدوي ؟ وما سن الطفل في هذه الفتره
        public bool? Drugs_Child { get; set; }//5-56 هل تناول الطفل اي عقاقير ؟
        
        public string Usage_Drug { get; set; }//6-57 اذا كانت الاجابة نعم فما هو نوع العقار ؟ وما سبب تناولة ؟ وما المدة ؟
        public bool? Surgery { get; set; }//7-58هل تم اجراء اي جراحات للطفل ؟
        
        public string Typesurgery { get; set; }//8-59 اذا كانت الاجابة نعم فما نوع الجراحة ؟ وما عمر الطفل عند اجرائها

        //السمع والبصر

        public bool? Hearing { get; set; }//9-60 هل توجد مشاكل خاصة بالسمع 
        
        public string Problemshearing { get; set; }//10-61اذا كانت الاجابة نعم فما هي هذة المشاكل
        
        public string Audiologist { get; set; }//11-62 ما اسم طبيب السمعيات  للسمع؟
        public bool? Eyesight { get; set; }//12-63هل توجد مشاكل خاصة بالبصر ؟
        
        public string Problemseyesight { get; set; }//13_64اذا كانت نعم فما هي المشاكل
        
        public string Ophthalmologist { get; set; }//14-65 ما اسم طبيب العيون  للبصر؟

        //معلومات عن الطفل

        public bool? Movement { get; set; }//15-66هل توجد مشاكل خاصه بالحركة؟
        
        public string Problemmovement { get; set; }//16-67اذا كانت نعم فما هي المشاكل؟
        
        public string Startsitting { get; set; }//17-68 متي بداء في الجلوس ؟
        
        public string Startwalking { get; set; }//18-69 متي بداء في المشي

        public string Physicaltherapy { get; set; }//19-70 هل يحصل الطفل علي جلسات علاج طبيعي بانتظام ؟وماعددالجلسات في الاسبوع؟

        public bool? Seizures { get; set; }//20-71هل الطفل يعاني من نوبان صرعيه؟
        public string Dco_Seizures { get; set; }//21-72اسم طبيب المخ والاعصاب المباشر للطفل؟

        
        public string Word_Spoken { get; set; }//22-73 بدأ في نطق اول كلمه؟

        
        public string Regular_Sessions { get; set; }//23-74 يحصل علي جلسات تخاطب بانتظام ؟ وما عدد الجلسات في الاسبوع؟

        
        public string Child_Communicate { get; set; }//24-75 كيف يتواصل الطفل مع الاخرين ؟هل من خلال السمع او البصر او اللمس؟


        //----------------------------------------------------/////
        public bool? Communicate_Any_One { get; set; }//1-76هل الطفل يتواصل مع اخواته؟
        public bool? Simple_Orders { get; set; }//2-77 يطيع الاوامر البسيطة؟
        public bool? Speak_Simple_Word { get; set; }//3-78 ينطق كلمات او يعبر بالاشارة؟

        
        public string Number_Words { get; set; }//4-79كم عدد الكلمات التي ينطقها او الاشارات؟ وماهي ؟

        public bool? Speak_Word { get; set; }//5-80 ينطق جمال؟


        
        public string Name_Doctr { get; set; }//6-81ما اسم اخصائي التخاطب القائم بجلسات الطفل ؟

        
        public string Name_Speech { get; set; }//7-82 اسم اخصائي التخاطب القائم بجلسات الطفل ؟


        
        public string Favorite_Activity { get; set; }//7-82 ماالنشاط المفضل للطفل ؟

        
        public string Favorite_Games { get; set; }//8-83 ما اللعبه المفضلة للطفل ؟

        
        public string More_Information { get; set; }//9-84 هل يوجد معلومات اضافيه ؟

        public DateTime Date_Add { get; set; } = DateTime.Today;
        public virtual List<Test> tests { get; set; }
    }
}

