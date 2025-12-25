namespace LinqKT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            bool exit = false;

            Console.WriteLine("----------Welcome To Library----------");

            while (!exit)
            {
                DisplayMainMenu();

                switch (Console.ReadLine())
                {
                    case "1":
                        ShowAllBooks(library);
                        break;
                    case "2":
                        ShowAllReaders(library);
                        break;
                    case "3":
                        BorrowBook(library);
                        break;
                    case "4":
                        ReturnBook(library);
                        break;
                    case "5":
                        SearchBooks(library);
                        break;
                    case "6":
                        AddNewBook(library);
                        break;
                    case "7":
                        AddNewReader(library);
                        break;
                    case "8":
                        ShowLibraryInfo(library);
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Please, enter only 0-8 for choose desired function!");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }

            static void DisplayMainMenu()
            {
                Console.WriteLine("\n----------Menu----------");
                Console.WriteLine("1 - Show all books");
                Console.WriteLine("2 - Show all readers");
                Console.WriteLine("3 - Borrow books");
                Console.WriteLine("4 - Return books");
                Console.WriteLine("5 - Search books");
                Console.WriteLine("6 - Add new book");
                Console.WriteLine("7 - Add new readers");
                Console.WriteLine("8 - Show library info");
                Console.WriteLine("0 - Exit");
                Console.Write("Select an option: ");
            }

            static void ShowAllBooks(Library library)
            {
                Console.WriteLine("\n----------All Books----------");
                library.ShowAllBooks();
            }

            static void ShowAllReaders(Library library)
            {
                Console.WriteLine("\n----------All Readers----------");
                library.ShowAllReaders();
            }

            static void BorrowBook(Library library)
            {
                Console.Write("\n----------Borrow Book----------" +
                    "\nEnter Reader ID: ");

                if (!int.TryParse(Console.ReadLine(), out int readerId))
                {
                    Console.WriteLine("Invalid Reader ID!");
                    return;
                }

                Console.Write("Enter Book Title: ");
                string bookTitle = Console.ReadLine();

                library.GetBook(readerId, bookTitle);
            }

            static void ReturnBook(Library library)
            {
                Console.Write("\n----------Return Book----------" +
                    "\nEnter Reader ID: ");

                if (!int.TryParse(Console.ReadLine(), out int readerId))
                {
                    Console.WriteLine("Invalid Reader ID!");
                    return;
                }

                Console.Write("Enter Book Title: ");
                string bookTitle = Console.ReadLine();

                library.ReturnBook(readerId, bookTitle);
            }

            static void SearchBooks(Library library)
            {
                Console.Write("\n----------Search Books----------" +
                    "\n Search by:" +
                    "\n1 - Title" +
                    "\n2 - Author" +
                    "\n3 - Year" +
                    "\n4 - Genre" +
                    "\n5 - Back to Menu" +
                    "\nEnter your choose: ");

                string enter = Console.ReadLine();

                if (enter == "5")
                {
                    return;
                }

                if (enter == "1" || enter == "2" || enter == "3" || enter == "4")
                {
                    string type;

                    switch (enter)
                    {
                        case "1":
                            type = "title";
                            break;
                        case "2":
                            type = "author";
                            break;
                        case "3":
                            type = "year";
                            break;
                        case "4":
                            type = "genre";
                            break;
                        default:
                            Console.WriteLine("Incorrect enter");
                            return;
                    }

                    Console.Write($"Enter {type} to search: ");
                    string condition = Console.ReadLine();

                    library.Search(type, condition);
                }
                else
                {
                    Console.WriteLine("Invalid search type!");
                }
            }

            static void AddNewBook(Library library)
            {
                Console.Write("\n----------Add New Book----------" +
                    "\nEnter Book Title: ");
                string title = Console.ReadLine();

                Console.Write("Enter Author: ");
                string author = Console.ReadLine();

                Console.Write("Enter Year: ");
                if (!int.TryParse(Console.ReadLine(), out int year))
                {
                    Console.WriteLine("Invalid year!");
                    return;
                }

                Console.Write("Enter Genre: ");
                string genre = Console.ReadLine();

                library.AddBook(title, author, year, genre);
            }

            static void AddNewReader(Library library)
            {
                Console.Write("\n----------Add New Reader----------" +
                    "\nEnter Reader Name: ");
                
                library.AddReader(Console.ReadLine());
            }

            static void ShowLibraryInfo(Library library)
            {
                Console.Write("\n----------Library Info----------" +
                    "\n1 - Available Books" +
                    "\n2 - Books by Genre" +
                    "\n3 - Top 3 Oldest Books" +
                    "\n4 - Books by Author" +
                    "\n5 - Back to Menu" +
                    "\nEnter your choose: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine(library.InfoWriter.AvailableBooks());
                        break;
                    case "2":
                        Console.Write("Enter Genre: ");
                        Console.WriteLine(library.InfoWriter.OneGenreBooks(Console.ReadLine()));
                        break;
                    case "3":
                        Console.WriteLine(library.InfoWriter.TopOldesBooks());
                        break;
                    case "4":
                        Console.Write("Enter Author Name: ");
                        Console.WriteLine(library.InfoWriter.OneAuthorBooks(Console.ReadLine()));
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Incorrect enter");
                        break;
                }
            }
        }
    }
}

/*
 Создать консольное приложение, которое демонстрирует 
    интеграцию LINQ для работы с данными и паттернов 
    проектирования для структуры кода. Приложение должно 
    моделировать простую систему управления библиотекой 
    (книги, авторы, читатели, выдача книг).


    Операции: Добавление книг/читателей, выдача/возврат 
    книг, поиск книг по критериям (используя LINQ). 

    Вывод отчетов: Список доступных книг, книги по жанру, топ-3 самых старых книг, группировка книг по авторам.
    Использовать только встроенные коллекции (List<T>, 
    Dictionary<T> и т.д.) для хранения данных.

    Инициализировать минимум 10 книг и 5 читателей в 
    коде
    Вывод: Всё через консоль (Console.WriteLine,
 */