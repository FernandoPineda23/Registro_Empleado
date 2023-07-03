using Empleado_23CV.Context;
using Empleado_23CV.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado_23CV.Service
{
    public class EmpleadoServices
    {
        public void Add(Empleado request)
        {
			try
			{
				using (var _context=new ApplicationDbContext())
				{
                    Empleado empleado = new Empleado()
                    {
                        Nombre = request.Nombre,
                        Apellido = request.Apellido,
                        FechaIngreso = DateTime.Now,
                        Correo = request.Correo,
                    };
                    _context.Empleados.Add(empleado);
                    _context.SaveChanges();
                }


			}
			catch (Exception ex)
			{

				throw new Exception("Ocurrio un problema"+ex.Message);
			}
        }
        public Empleado Read(int Id)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    Empleado empleado = _context.Empleados.Find(Id);
                    return empleado;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrior un error" + ex.Message);
            }
        }
        public void Editar(int id, Empleado empleadoActualizado)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {

                    Empleado empleado = _context.Empleados.Find(id);

                    if (empleado != null)
                    {

                        empleado.Nombre = empleadoActualizado.Nombre;
                        empleado.Apellido = empleadoActualizado.Apellido;
                        empleado.FechaIngreso = empleadoActualizado.FechaIngreso;
                        empleado.Correo = empleadoActualizado.Correo;

                        _context.Update(empleado);
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error: " + ex.Message);
            }
        }
        public void Eliminar(int id)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {

                    Empleado empleado = _context.Empleados.Find(id);

                    if (empleado != null)
                    {

                        _context.Empleados.Remove(empleado);
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error: " + ex.Message);
            }
        }
    }
}
