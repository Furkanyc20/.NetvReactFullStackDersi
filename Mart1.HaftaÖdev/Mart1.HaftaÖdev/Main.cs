using ProgrammingLanguagesManagement;
using System;
using System.Collections.Generic;

namespace ProgrammingLanguagesManagement
{
    // Entities Katmanı
    public class ProgrammingLanguage
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Technology
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProgrammingLanguage ProgrammingLanguage { get; set; }
    }

    // Data Access Katmanı
    public interface IRepository<T>
    {
        void Add(T entity);
        void Delete(int id);
        void Update(T entity);
        T GetById(int id);
        List<T> GetAll();
    }

    public class ProgrammingLanguageRepository : IRepository<ProgrammingLanguage>
    {
        private List<ProgrammingLanguage> languages = new List<ProgrammingLanguage>();

        public void Add(ProgrammingLanguage entity) => languages.Add(entity);
        public void Delete(int id) => languages.RemoveAll(l => l.Id == id);
        public void Update(ProgrammingLanguage entity)
        {
            var lang = GetById(entity.Id);
            if (lang != null) lang.Name = entity.Name;
        }
        public ProgrammingLanguage GetById(int id) => languages.Find(l => l.Id == id);
        public List<ProgrammingLanguage> GetAll() => languages;
    }

    // Business Katmanı
    public class ProgrammingLanguageManager
    {
        private readonly IRepository<ProgrammingLanguage> _repository;

        public ProgrammingLanguageManager(IRepository<ProgrammingLanguage> repository)
        {
            _repository = repository;
        }

        public void AddProgrammingLanguage(string name)
        {
            var newLanguage = new ProgrammingLanguage { Id = new Random().Next(1, 1000), Name = name };
            _repository.Add(newLanguage);
            Console.WriteLine($"{name} dili başarıyla eklendi.");
        }

        public void DeleteProgrammingLanguage(int id)
        {
            _repository.Delete(id);
            Console.WriteLine($"ID {id} olan programlama dili silindi.");
        }

        public void UpdateProgrammingLanguage(int id, string newName)
        {
            var existingLanguage = _repository.GetById(id);
            if (existingLanguage != null)
            {
                existingLanguage.Name = newName;
                _repository.Update(existingLanguage);
                Console.WriteLine($"ID {id} olan programlama dili {newName} olarak güncellendi.");
            }
            else
            {
                Console.WriteLine($"ID {id} olan programlama dili bulunamadı.");
            }
        }
        public void ListProgrammingLanguages()
        {
            var languages = _repository.GetAll();
            Console.WriteLine("\n Tüm Programlama Dilleri:");
            Console.WriteLine();
            foreach (var language in languages)
            {
                Console.WriteLine($"ID: {language.Id}, Name: {language.Name}");
            }
        }

        public void GetProgrammingLanguageById(int id)
        {
            var language = _repository.GetById(id);
            if (language != null)
            {
                Console.WriteLine($"Bulunan Programlama Dili -> ID: {language.Id}, Name: {language.Name}");
            }
            else
            {
                Console.WriteLine($"ID {id} olan programlama dili bulunamadı.");
            }
        }
    }

}
// Presentation Katmanı
class Program
{
    static void Main(string[] args)
    {
        IRepository<ProgrammingLanguage> repository = new ProgrammingLanguageRepository();
        ProgrammingLanguageManager manager = new ProgrammingLanguageManager(repository);

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("PROGRAMLAMA DİLLERİ YÖNETİMİ");
            Console.WriteLine("1 - Programlama Dili Ekle");
            Console.WriteLine("2 - Programlama Dili Sil");
            Console.WriteLine("3 - Programlama Dili Güncelle");
            Console.WriteLine("4 - Tüm Programlama Dillerini Listele");
            Console.WriteLine("5 - ID'ye Göre Programlama Dili Getir");
            Console.WriteLine("0 - Çıkış");
            Console.WriteLine();
            Console.Write("Seçiminizi yapın: ");
            string number = Console.ReadLine();

            switch (number)
            {
                case "1":
                    Console.Write("Eklemek istediğiniz programlama dilinin adını girin: ");
                    string name = Console.ReadLine();
                    manager.AddProgrammingLanguage(name);
                    break;

                case "2":
                    Console.Write("Silmek istediğiniz programlama dilinin ID'sini girin: ");
                    if (int.TryParse(Console.ReadLine(), out int deleteId))
                    {
                        manager.DeleteProgrammingLanguage(deleteId);
                    }
                    else
                    {
                        Console.WriteLine(" Geçersiz ID girdiniz.");
                    }
                    break;

                case "3":
                    Console.Write("Güncellemek istediğiniz programlama dilinin ID'sini girin: ");
                    if (int.TryParse(Console.ReadLine(), out int updateId))
                    {
                        Console.Write("Yeni programlama dili adını girin: ");
                        string newName = Console.ReadLine();
                        manager.UpdateProgrammingLanguage(updateId, newName);
                    }
                    else
                    {
                        Console.WriteLine(" Geçersiz ID girdiniz.");
                    }
                    break;

                case "4":
                    manager.ListProgrammingLanguages();
                    break;

                case "5":
                    Console.Write("Görmek istediğiniz programlama dilinin ID'sini girin: ");
                    if (int.TryParse(Console.ReadLine(), out int searchId))
                    {
                        manager.GetProgrammingLanguageById(searchId);
                    }
                    else
                    {
                        Console.WriteLine(" Geçersiz ID girdiniz.");
                    }
                    break;

                case "0":
                    Console.WriteLine("Programdan çıkılıyor.");
                    return;

                default:
                    Console.WriteLine(" Geçersiz seçim! Lütfen tekrar deneyin.");
                    break;
            }
        }
    }
}