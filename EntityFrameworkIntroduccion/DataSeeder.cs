using EntityBasicoDAL;
using System.Runtime.CompilerServices;

namespace EntityFrameworkIntroduccion
{
    //CON ESTA CLASE GENERAMOS LA INSERCION
    public static class DataSeeder
    {
        public static void Seed(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<AccesoDC>();
            context.Database.EnsureCreated();
            AddEmpleados(context);
        }

        private static void AddEmpleados(AccesoDC context)
        {
            var empleado = context.empleados.FirstOrDefault();

            context.empleados.Add(new empleado
            {
                Id = 2,
                nombre_empleado = "Valentino Rossi",
                nivel_accesos = new List<nivel_acc> {

                    new nivel_acc { 
                        Id = 2,
                        nivel_acceso = "Muy Alto", 
                        desc_acceso = "Il Doctore"
                    }
                }
            });

            context.SaveChanges();
        }
    }
}
