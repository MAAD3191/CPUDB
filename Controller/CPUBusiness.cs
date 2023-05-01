
using CPUDB.Model;
using CPUDB.Model.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUDB.Controller
{
    public class CPUBusiness
    {
        
        private CPUContext cpuContext;

        public CPUBusiness(CPUContext cpuContext)
        {
            this.cpuContext = cpuContext;
        }

        public List<CPUItem> GetAllCPU()
        {
            return cpuContext.CPUs
                .Include(b => b.Brand)
                .Include(m => m.Model)
                .ToList();
        }
        public List<Brand> GetAllBrands()
        {
            return cpuContext.Brands
                .ToList();
        }

        public List<CPUModel> GetAllCPUModels()
        {
            return cpuContext.Models
                .ToList();
        }
        
        public CPUItem GetCPU(int id)
        {
            return cpuContext.CPUs
                .Include(c => c.Brand)
                .Include(c => c.Model)
                .Where(c => c.Id == id)
                .FirstOrDefault();
        }
        public Brand GetBrand(int id)
        {
            return cpuContext.Brands
                .Where(b => b.Id == id)
                .FirstOrDefault();
        }

        public CPUModel GetCPUModel(int id)
        {
            return cpuContext.Models
                .Where(m => m.Id == id)
                .FirstOrDefault();
        }

        public void AddCPU(CPUItem cpu)
        {
            cpuContext.CPUs.Add(cpu);
            cpuContext.SaveChanges();
        }
        public void AddBrand(Brand brand)
        {
            cpuContext.Brands.Add(brand);
            cpuContext.SaveChanges();
        }
        public void AddCPUModel(CPUModel cpuModel)
        {
            cpuContext.Models.Add(cpuModel);
            cpuContext.SaveChanges();
        }
        
        public void UpdateCPU(CPUItem cpu)
        {
            var item = GetCPU(cpu.Id);
            if (item != null)
            {
                cpuContext.CPUs.Update(cpu);
                cpuContext.SaveChanges();
            }
        }
        public void UpdateBrand(Brand brand)
        {
            var item = GetBrand(brand.Id);
            if (item != null)
            {
                cpuContext.Brands.Update(brand);
                cpuContext.SaveChanges();
            }
        }
       
        public void UpdateCPUModels(CPUModel cpuModel)
        {
            var item = GetCPUModel(cpuModel.Id);
            if (item != null)
            {
                cpuContext.Models.Update(cpuModel);
                cpuContext.SaveChanges();
            }
        }
        
        public void DeleteCPU(int id)
        {
            var item = GetCPU(id);
            if (item != null)
            {
                cpuContext.CPUs.Remove(item);
                cpuContext.SaveChanges();
            }
        }
        public void DeleteBrand(int id)
        {
            var item = GetBrand(id);
            if (item != null)
            {
                cpuContext.Brands.Remove(item);
                cpuContext.SaveChanges();
            }
        }
        public void DeleteCPUModel(int id)
        {
            var item = GetCPUModel(id);
            if (item != null)
            {
                cpuContext.Models.Remove(item);
                cpuContext.SaveChanges();
            }
        }
    }
}
