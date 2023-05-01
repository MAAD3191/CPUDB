using CPUDB.Controller;
using CPUDB.Model;
using CPUDB.Model.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUDB.View
{
    
    public class Display
    {
        
        CPUBusiness cpuBusiness;
        private int closeOperationId = 5;
        public Display(CPUContext context) //imam rak
        {
            cpuBusiness = new CPUBusiness(context);
            Input();
        }
        private void Input()
        {
            int operation = -1;
            int secondOperation = -1;
            do
            {
                Title();
                MainMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        Console.Clear();
                        AddMenu();
                        secondOperation= int.Parse(Console.ReadLine());
                        switch (secondOperation)
                        {
                            case 1:
                                AddCPU();
                                break;
                            case 2:
                                AddBrand();
                                break;
                            case 3:
                                AddCPUModel();
                                break;
                            case 4:
                                Console.Clear();
                                break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        UpdateMenu();
                        secondOperation = int.Parse(Console.ReadLine());
                        switch (secondOperation)
                        {
                            case 1:
                                UpdateCPU();
                                break;
                            case 2:
                                UpdateBrand();
                                break;
                            case 3:
                                UpdateCPUModel();
                                break;
                            case 4:
                                Console.Clear();
                                break;
                        }
                        break;
                    case 3:
                        Console.Clear();
                        DeleteMenu();
                        secondOperation= int.Parse(Console.ReadLine());
                        switch (secondOperation)
                        {
                            case 1:
                                DeleteCPU();
                                break; 
                            case 2:
                                DeleteBrand();
                                break;
                            case 3:
                                DeleteCPUModel();
                                break;
                            case 4:
                                Console.Clear();
                                break;
                        }
                        break;
                        
                    case 4:
                        Console.Clear();
                        ListMenu();
                        secondOperation= int.Parse(Console.ReadLine());
                        switch (secondOperation)
                        {
                            case 1:
                                ListCPU();
                                break;
                            case 2:
                                ListBrand();
                                break;
                            case 3:
                                ListCPUModel();
                                break;
                            case 4:
                                ListAllCPUs();
                                break;
                            case 5:
                                ListAllBrands();
                                break;
                            case 6:
                                ListAllModels();
                                break;
                            case 7:
                                Console.Clear();
                                break;
                        }
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Goodbye!");
                        break;

                }

                
            } while (operation != closeOperationId);
        }
        //Menus
        private void Title() 
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("****WELCOME TO MAAD'S COZY CPU DATABASE****");
            Console.WriteLine("*******************************************");
        }

        private void MainMenu()
        {
            Console.WriteLine(" __ __  ___  _ _  _ _ " +
                       "\r\n|  \\  \\| __>| \\ || | |" +
                          "\r\n|     || _> |   || ' |" +
                         "\r\n|_|_|_||___>|_\\_|`___'" +
                          "\r\n                      ");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Update");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. List");
            Console.WriteLine("5. Exit");
        }
        private void AddMenu()
        {
            Console.WriteLine(" ___  ___  ___ " +
                        "\r\n| . || . \\| . \\" +
                        "\r\n|   || | || | |" +
                        "\r\n|_|_||___/|___/" +
                        "\r\n               ");
            Console.WriteLine("1. Add CPU");
            Console.WriteLine("2. Add CPU Brand");
            Console.WriteLine("3. Add CPU Model");
            Console.WriteLine("4. Back to Main Menu");

        }
        private void UpdateMenu() 
        {
            Console.WriteLine(" _ _  ___  ___  ___  ___  ___ " +
                          "\r\n| | || . \\| . \\| . ||_ _|| __>" +
                          "\r\n| ' ||  _/| | ||   | | | | _> " +
                          "\r\n`___'|_|  |___/|_|_| |_| |___>" +
                          "\r\n                              ");
            Console.WriteLine("1. Update CPU");
            Console.WriteLine("2. Update CPU Brand");
            Console.WriteLine("3. Update CPU Model");
            Console.WriteLine("4. Back to Main Menu");
        }
        private void DeleteMenu()
        {
            Console.WriteLine(" ___  ___  _    ___  ___  ___ " +
                          "\r\n| . \\| __>| |  | __>|_ _|| __>" +
                          "\r\n| | || _> | |_ | _>  | | | _> " +
                          "\r\n|___/|___>|___||___> |_| |___>" +
                          "\r\n                              ");
            Console.WriteLine("1. Delete CPU");
            Console.WriteLine("2. Delete CPU Brand");
            Console.WriteLine("3. Delete CPU Model");
            Console.WriteLine("4. Back to Main Menu");
        }
        private void ListMenu()
        {
            Console.WriteLine(" _    _  ___  ___ " +
                          "\r\n| |  | |/ __>|_ _|" +
                          "\r\n| |_ | |\\__ \\ | | " +
                          "\r\n|___||_|<___/ |_| " +
                          "\r\n                 ");
            Console.WriteLine("1. List a specific CPU");
            Console.WriteLine("2. List a specific CPU Brand");
            Console.WriteLine("3. List a specific CPU Model");
            Console.WriteLine("4. List all CPUs");
            Console.WriteLine("5. List all CPU Brands");
            Console.WriteLine("6. List all CPU Models");
            Console.WriteLine("7. Back to Main Menu");
        }
        //Add
        private void AddCPU()
        {
            CPUItem cpu = new CPUItem();

            Console.Write("Enter brand id: ");
            cpu.BrandId = int.Parse(Console.ReadLine());

            Console.Write("Enter model id: ");
            cpu.ModelId = int.Parse(Console.ReadLine());

            Console.Write("Enter CPU clock speed: ");
            cpu.Clock_speed = float.Parse(Console.ReadLine());

            Console.Write("Enter CPU core amount: ");
            cpu.Core_amount = int.Parse(Console.ReadLine());

            Console.Write("Enter CPU thread amount: ");
            cpu.Thread_amount = int.Parse(Console.ReadLine());

            cpuBusiness.AddCPU(cpu);
        }
        private void AddBrand()
        {
            Brand brand = new Brand();
            Console.Write("Enter brand name: ");
            brand.Name = Console.ReadLine();
            cpuBusiness.AddBrand(brand);
;
        }
        private void AddCPUModel()
        {
            CPUModel model = new CPUModel();
            Console.Write("Enter model name: ");
            model.Name = Console.ReadLine();
            cpuBusiness.AddCPUModel(model);
        }

        //Delete
        private void DeleteCPU()
        {
            Console.Write("Enter CPU id to delete: ");
            int id = int.Parse(Console.ReadLine());
            cpuBusiness.DeleteCPU(id);
            Console.WriteLine("CPU deleted!");
        }
        private void DeleteBrand()
        {
            Console.Write("Enter Brand id to delete: ");
            int id = int.Parse(Console.ReadLine());
            cpuBusiness.DeleteBrand(id);
            Console.WriteLine("Brand deleted!");
        }
        private void DeleteCPUModel()
        {
            Console.Write("Enter CPUModel id to delete: ");
            int id = int.Parse(Console.ReadLine());
            cpuBusiness.DeleteCPUModel(id);
            Console.WriteLine("CPUModel deleted!");
        }

        //Update
        private void UpdateCPU()
        {
            Console.Write("Enter id to update: ");
            int id = int.Parse(Console.ReadLine());
            CPUItem cpu = cpuBusiness.GetCPU(id);
            if (cpu != null)
            {
                Console.Write("Enter brand id: ");
                cpu.BrandId = int.Parse(Console.ReadLine());

                Console.Write("Enter model id: ");
                cpu.ModelId = int.Parse(Console.ReadLine());

                Console.Write("Enter CPU clock speed: ");
                cpu.Clock_speed = float.Parse(Console.ReadLine());

                Console.Write("Enter CPU core amount: ");
                cpu.Core_amount = int.Parse(Console.ReadLine());

                Console.Write("Enter CPU thread amount: ");
                cpu.Thread_amount = int.Parse(Console.ReadLine());

                cpuBusiness.UpdateCPU(cpu);
            }
        }
        private void UpdateBrand()
        {
            Console.Write("Enter id to update: ");
            int id = int.Parse(Console.ReadLine());
            Brand brand = cpuBusiness.GetBrand(id);
            if (brand != null)
            {
                Console.Write("Enter brand name: ");
                brand.Name = Console.ReadLine();
                cpuBusiness.UpdateBrand(brand);
            }
        }
        private void UpdateCPUModel() 
        {
            Console.Write("Enter id to update: ");
            int id = int.Parse(Console.ReadLine());
            CPUModel cpuModel = cpuBusiness.GetCPUModel(id); 
            if (cpuModel != null) 
            {
                Console.Write("Enter model name: ");
                cpuModel.Name = Console.ReadLine();
                cpuBusiness.UpdateCPUModels(cpuModel);
            }
        }
        //List All
        private void ListAllCPUs()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Id | Brand | Model | Clock Speed | Cores | Threads");
            Console.WriteLine("---------------------------------------------------");
            var cpus = cpuBusiness.GetAllCPU();
            foreach (var cpu in cpus)
            {
                Console.WriteLine(String.Format("{0,-2} | {1,-5} | {2,-5} | {3,-11} | {4,-5} | {5,-6}", cpu.Id, cpu.Brand.Name, cpu.Model.Name, cpu.Clock_speed, cpu.Core_amount, cpu.Thread_amount));

            }
            Console.WriteLine("---------------------------------------------------");
        }
        private void ListAllBrands()
        {
            var brands = cpuBusiness.GetAllBrands();
            Console.WriteLine("----------");
            Console.WriteLine("Id | Brand");
            Console.WriteLine("----------");
            foreach (var brand in brands)
            {
                Console.WriteLine("{0,-2} | {1,-5}", brand.Id, brand.Name);
            }
        }
        private void ListAllModels()
        {
            var cpus = cpuBusiness.GetAllCPUModels();
            Console.WriteLine("----------");
            Console.WriteLine("Id | Model");
            Console.WriteLine("----------");
            foreach (var model in cpus)
            {
                Console.WriteLine(String.Format("{0,-2} | {1,-5}", model.Id, model.Name));
            }
        }
        //List
        private void ListCPU()
        {
            int id = int.Parse(Console.ReadLine()); 
            CPUItem cpu = cpuBusiness.GetCPU(id);
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Id | Brand | Model | Clock Speed | Cores | Threads");
            Console.WriteLine("---------------------------------------------------");
            if (cpu != null)
            {
                Console.WriteLine(String.Format("{0,-2} | {1,-5} | {2,-5} | {3,-11} | {4,-5} | {5,-6}", cpu.Id, cpu.Brand.Name, cpu.Model.Name, cpu.Clock_speed, cpu.Core_amount, cpu.Thread_amount));
            }
        }
        private void ListCPUModel()
        {
            int id = int.Parse(Console.ReadLine());
            CPUModel model = cpuBusiness.GetCPUModel(id);
            Console.WriteLine("----------");
            Console.WriteLine("Id | Model");
            Console.WriteLine("----------");
            if (model != null)
            {
                Console.WriteLine(String.Format("{0,-2} | {1,-5}", model.Id, model.Name));
            }
        }
        private void ListBrand()
        {
            int id = int.Parse(Console.ReadLine());
            Brand brand = cpuBusiness.GetBrand(id);
            Console.WriteLine("----------");
            Console.WriteLine("Id | Brand");
            Console.WriteLine("----------");
            if (brand != null)
            {
                Console.WriteLine("{0,-2} | {1,-5}",brand.Id, brand.Name);
            }
        }
    }
}
