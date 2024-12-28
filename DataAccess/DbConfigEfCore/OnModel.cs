using DataAccess.DbContextEfCore;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DbConfigEfCore
{
    public static class OnModel 
    {
        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
        modelBuilder.Entity<EntityDepartment>().HasData(
            new EntityDepartment { EntityDepartmentId = 1, DepartmentName = "Dahiliye (İç Hastalıkları)" },
            new EntityDepartment { EntityDepartmentId = 2, DepartmentName = "Genel Cerrahi" },
            new EntityDepartment { EntityDepartmentId = 3, DepartmentName = "Kadın Doğum (Obstetrik ve Jinekoloji)" },
            new EntityDepartment { EntityDepartmentId = 4, DepartmentName = "Radyoloji" },
            new EntityDepartment { EntityDepartmentId = 5, DepartmentName = "Pediatri (Çocuk Sağlığı ve Hastalıkları)" },
            new EntityDepartment { EntityDepartmentId = 6, DepartmentName = "Göz Hastalıkları (Oftalmoloji)" },
            new EntityDepartment { EntityDepartmentId = 7, DepartmentName = "Kulak Burun Boğaz (KBB)" },
            new EntityDepartment { EntityDepartmentId = 8, DepartmentName = "Nöroloji" },
            new EntityDepartment { EntityDepartmentId = 9, DepartmentName = "Ortopedi" },
            new EntityDepartment { EntityDepartmentId = 10, DepartmentName = "Psikiyatri" },
            new EntityDepartment { EntityDepartmentId = 11, DepartmentName = "Oral ve Diş Sağlığı" },
            new EntityDepartment { EntityDepartmentId = 12, DepartmentName = "Fizyoterapi ve Rehabilitasyon" }
        );

        modelBuilder.Entity<EntitySection>().HasData(
            new EntitySection { EntitySectionId = 1, SectionName = "Kardiyoloji", EntityDepartmentId = 1 },
            new EntitySection { EntitySectionId = 2, SectionName = "Gastroenteroloji", EntityDepartmentId = 1 },
            new EntitySection { EntitySectionId = 3, SectionName = "Nefroloji", EntityDepartmentId = 1 },
            new EntitySection { EntitySectionId = 4, SectionName = "Endokrinoloji", EntityDepartmentId = 1 },
            new EntitySection { EntitySectionId = 5, SectionName = "Pulmonoloji", EntityDepartmentId = 1 },
            new EntitySection { EntitySectionId = 6, SectionName = "Hematoloji", EntityDepartmentId = 1 },

            new EntitySection { EntitySectionId = 7, SectionName = "Kolon ve Rektum Cerrahisi", EntityDepartmentId = 2 },
            new EntitySection { EntitySectionId = 8, SectionName = "Gastrointestinal Cerrahi", EntityDepartmentId = 2 },
            new EntitySection { EntitySectionId = 9, SectionName = "Meme Cerrahisi", EntityDepartmentId = 2 },
            new EntitySection { EntitySectionId = 10, SectionName = "Tiroid ve Paratiroid Cerrahisi", EntityDepartmentId = 2 },
            new EntitySection { EntitySectionId = 11, SectionName = "Yara Bakımı ve Travma Cerrahisi", EntityDepartmentId = 2 },

            new EntitySection { EntitySectionId = 12, SectionName = "Obstetrik (Doğum Bilimi)", EntityDepartmentId = 3 },
            new EntitySection { EntitySectionId = 13, SectionName = "Jinekoloji", EntityDepartmentId = 3 },

            new EntitySection { EntitySectionId = 14, SectionName = "Röntgen", EntityDepartmentId = 4 },
            new EntitySection { EntitySectionId = 15, SectionName = "Bilgisayarlı Tomografi (BT)", EntityDepartmentId = 4 },
            new EntitySection { EntitySectionId = 16, SectionName = "Manyetik Rezonans Görüntüleme (MR)", EntityDepartmentId = 4 },
            new EntitySection { EntitySectionId = 17, SectionName = "Ultrasonografi (USG)", EntityDepartmentId = 4 },
            new EntitySection { EntitySectionId = 18, SectionName = "Nükleer Tıp (Sintigrafi)", EntityDepartmentId = 4 },

            new EntitySection { EntitySectionId = 19, SectionName = "Genel Pediatri", EntityDepartmentId = 5 },
            new EntitySection { EntitySectionId = 20, SectionName = "Neonatoloji", EntityDepartmentId = 5 },
            new EntitySection { EntitySectionId = 21, SectionName = "Çocuk Enfeksiyon Hastalıkları", EntityDepartmentId = 5 },
            new EntitySection { EntitySectionId = 22, SectionName = "Çocuk Nefrolojisi", EntityDepartmentId = 5 },
            new EntitySection { EntitySectionId = 23, SectionName = "Çocuk Kardiyolojisi", EntityDepartmentId = 5 },
            new EntitySection { EntitySectionId = 24, SectionName = "Çocuk Endokrinolojisi", EntityDepartmentId = 5 },
            new EntitySection { EntitySectionId = 25, SectionName = "Çocuk Psikiyatrisi", EntityDepartmentId = 5 },

            new EntitySection { EntitySectionId = 26, SectionName = "Genel Oftalmoloji", EntityDepartmentId = 6 },
            new EntitySection { EntitySectionId = 27, SectionName = "Katarakt Cerrahisi", EntityDepartmentId = 6 },
            new EntitySection { EntitySectionId = 28, SectionName = "Retina ve Vitreus Hastalıkları", EntityDepartmentId = 6 },
            new EntitySection { EntitySectionId = 29, SectionName = "Kornea Hastalıkları ve Kornea Transplantasyonu", EntityDepartmentId = 6 },
            new EntitySection { EntitySectionId = 30, SectionName = "Glaukom (Göz Tansiyonu) Tedavisi", EntityDepartmentId = 6 },
            new EntitySection { EntitySectionId = 31, SectionName = "Pediyatrik Oftalmoloji", EntityDepartmentId = 6 },
            new EntitySection { EntitySectionId = 32, SectionName = "Plastik ve Rekonstrüktif Göz Cerrahisi", EntityDepartmentId = 6 },
            new EntitySection { EntitySectionId = 33, SectionName = "Üveit (Göz İçi İltihabı) Tedavisi", EntityDepartmentId = 6 },
            new EntitySection { EntitySectionId = 34, SectionName = "Orbita ve Oküloplasti", EntityDepartmentId = 6 },

            new EntitySection { EntitySectionId = 35, SectionName = "Kulak Hastalıkları", EntityDepartmentId = 7 },
            new EntitySection { EntitySectionId = 36, SectionName = "Burun ve Sinüs Hastalıkları", EntityDepartmentId = 7 },
            new EntitySection { EntitySectionId = 37, SectionName = "Boğaz Hastalıkları", EntityDepartmentId = 7 },
            new EntitySection { EntitySectionId = 38, SectionName = "Baş ve Boyun Cerrahisi", EntityDepartmentId = 7 },
            new EntitySection { EntitySectionId = 39, SectionName = "Çocuklar için Kulak Burun Boğaz", EntityDepartmentId = 7 },

            new EntitySection { EntitySectionId = 40, SectionName = "Baş Ağrıları ve Migren Tedavisi", EntityDepartmentId = 8 },
            new EntitySection { EntitySectionId = 41, SectionName = "Epilepsi ve Nöbet Bozuklukları", EntityDepartmentId = 8 },
            new EntitySection { EntitySectionId = 42, SectionName = "Nöromüsküler Hastalıklar", EntityDepartmentId = 8 },
            new EntitySection { EntitySectionId = 43, SectionName = "İnme (Stroke)", EntityDepartmentId = 8 },
            new EntitySection { EntitySectionId = 44, SectionName = "Hareket Bozuklukları", EntityDepartmentId = 8 },
            new EntitySection { EntitySectionId = 45, SectionName = "Demyelinizan Hastalıklar", EntityDepartmentId = 8 },
            new EntitySection { EntitySectionId = 46, SectionName = "Nöroonkoloji", EntityDepartmentId = 8 },
            new EntitySection { EntitySectionId = 47, SectionName = "Nöroimmünoloji", EntityDepartmentId = 8 },
            new EntitySection { EntitySectionId = 48, SectionName = "Nörofizyoloji", EntityDepartmentId = 8 },

            new EntitySection { EntitySectionId = 49, SectionName = "Artroplasti (Eklem Protezi)", EntityDepartmentId = 9 },
            new EntitySection { EntitySectionId = 50, SectionName = "Travmatoloji", EntityDepartmentId = 9 },
            new EntitySection { EntitySectionId = 51, SectionName = "Pediatrik Ortopedi", EntityDepartmentId = 9 },
            new EntitySection { EntitySectionId = 52, SectionName = "Omurga Cerrahisi", EntityDepartmentId = 9 },
            new EntitySection { EntitySectionId = 53, SectionName = "El ve Üst Ekstremite Cerrahisi", EntityDepartmentId = 9 },
            new EntitySection { EntitySectionId = 54, SectionName = "Ayak ve Ayak Bileği Cerrahisi", EntityDepartmentId = 9 },
            new EntitySection { EntitySectionId = 55, SectionName = "Ortopedik Onkoloji", EntityDepartmentId = 9 },
            new EntitySection { EntitySectionId = 56, SectionName = "Ortopedik Rehabilitasyon", EntityDepartmentId = 9 },

            new EntitySection { EntitySectionId = 57, SectionName = "Genel Psikiyatri", EntityDepartmentId = 10 },
            new EntitySection { EntitySectionId = 58, SectionName = "Çocuk ve Ergen Psikiyatrisi", EntityDepartmentId = 10 },
            new EntitySection { EntitySectionId = 59, SectionName = "Bağımlılık Psikiyatrisi", EntityDepartmentId = 10 },
            new EntitySection { EntitySectionId = 60, SectionName = "Ruhsal Sağlık ve Psikoterapi", EntityDepartmentId = 10 },
            new EntitySection { EntitySectionId = 61, SectionName = "Klinik Psikofarmakoloji", EntityDepartmentId = 10 },
            new EntitySection { EntitySectionId = 62, SectionName = "Acil Psikiyatri", EntityDepartmentId = 10 },
            new EntitySection { EntitySectionId = 63, SectionName = "Geropsikiyatri", EntityDepartmentId = 10 },
            new EntitySection { EntitySectionId = 64, SectionName = "Adli Psikiyatri", EntityDepartmentId = 10 },

            new EntitySection { EntitySectionId = 65, SectionName = "Genel Diş Hekimliği", EntityDepartmentId = 11 },
            new EntitySection { EntitySectionId = 66, SectionName = "Periodontoloji", EntityDepartmentId = 11 },
            new EntitySection { EntitySectionId = 67, SectionName = "Endodonti", EntityDepartmentId = 11 },
            new EntitySection { EntitySectionId = 68, SectionName = "Ortodonti", EntityDepartmentId = 11 },
            new EntitySection { EntitySectionId = 69, SectionName = "Oral ve Maksillofasiyal Cerrahi", EntityDepartmentId = 11 },
            new EntitySection { EntitySectionId = 70, SectionName = "Prostodonti", EntityDepartmentId = 11 },
            new EntitySection { EntitySectionId = 71, SectionName = "Estetik Diş Hekimliği", EntityDepartmentId = 11 },

            new EntitySection { EntitySectionId = 72, SectionName = "Ortopedik Fizyoterapi", EntityDepartmentId = 12 },
            new EntitySection { EntitySectionId = 73, SectionName = "Nörolojik Fizyoterapi", EntityDepartmentId = 12 },
            new EntitySection { EntitySectionId = 74, SectionName = "Kardiyopulmoner Fizyoterapi", EntityDepartmentId = 12 },
            new EntitySection { EntitySectionId = 75, SectionName = "Pediyatrik Fizyoterapi", EntityDepartmentId = 12 },
            new EntitySection { EntitySectionId = 76, SectionName = "Geriyatrik Fizyoterapi", EntityDepartmentId = 12 },
            new EntitySection { EntitySectionId = 77, SectionName = "Spor Fizyoterapisi", EntityDepartmentId = 12 },
            new EntitySection { EntitySectionId = 78, SectionName = "Fiziksel Tıp ve Rehabilitasyon", EntityDepartmentId = 12 },
            new EntitySection { EntitySectionId = 79, SectionName = "Onkolojik Fizyoterapi", EntityDepartmentId = 12 }


        );
         
        }
           
    }
}