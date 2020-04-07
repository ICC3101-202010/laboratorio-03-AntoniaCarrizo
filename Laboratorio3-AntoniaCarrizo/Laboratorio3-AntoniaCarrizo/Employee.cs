using System;
using System.Collections.Generic;

namespace Laboratorio3AntoniaCarrizo
{
    public class Employee:Person
    {
        //atributos
        private string job;
        private int salary;
        private string timetable;

        //lista de empleados
        private List<Employee> listemployee = new List<Employee>();

        public Employee(string job, int salary, string timetable, string rut, string name, string lastname, string datebirth, string nationality): base(rut,name,lastname,datebirth,nationality)
        {
            this.job = job;
            this.salary = salary;
            this.timetable = timetable;
        }
        public Employee()
        {

        }

        //Retornar los datos
        public string Job()
        {
            return job;
        }
        public int Salary()
        {
            return salary;
        }
        public string Timetable()
        {
            return timetable;
        }


        //metodos

        public bool Agregarempleado (Employee employee)
        {
            for (int a=0;a<listemployee.Count;)
            {
                if (listemployee[a].Rut() == employee.Rut())
                { 
                    Console.WriteLine("El empleado ya estaba agregado");
                    return false;
                }
                else
                {
                    a++;
                }

            }
            listemployee.Add(employee);
            return true;


        }
        public void VerEmpleados()
        {
            int n = 1;
            for (int i = 0; i < listemployee.Count; i++)
            {
                Console.WriteLine(n + ") Rut: " + listemployee[i].Rut() + "- Nombre: " + listemployee[i].Name() + "- Apellido: " + listemployee[i].Lastname() + "- Nacimiento: " + listemployee[i].Datebirth() + "- Nacionalidad: " + listemployee[i].Nationality() + "- Empleo: " + listemployee[i].Job() + "- Salario: " + listemployee[i].Salary() + "- Horario trabajo: " + listemployee[i].Timetable());
                n++;
            }

            
        }
        
        public bool Cambiartrabajo (string newjob,string rut)
        {
            for (int a = 0; a < listemployee.Count;)
            {
                if (listemployee[a].Rut() == rut)
                {
                    string antiguojob = listemployee[a].Job();
                    int salario = listemployee[a].Salary();
                    string horario = listemployee[a].Timetable();
                    string nombre = listemployee[a].Name();
                    string apellido = listemployee[a].Lastname();
                    string nacimiento = listemployee[a].Datebirth();
                    string nacionalidad = listemployee[a].Nationality();

                    listemployee.RemoveAt(a);
                    Employee em = new Employee(newjob, salario, horario, rut, nombre, apellido, nacimiento, nacionalidad);
                    listemployee.Insert(a,em);

                    Console.WriteLine("El trabajo del empleado: " + rut + " - " + nombre + " "+ apellido+ "\n Cambió de : "+antiguojob +" a "+ newjob);
                    return true;
                }
                else
                {
                    a++;
                    
                }

            }
            Console.WriteLine("El empleado no existe");
            return false;

        }
        
        public bool Cambiarsueldo (int newsalary, string rut)
        {
            for (int a = 0; a < listemployee.Count;)
            {
                if (listemployee[a].Rut() == rut)
                {
                    string trabajo = listemployee[a].Job();
                    int salario = listemployee[a].Salary();
                    string horario = listemployee[a].Timetable();
                    string nombre = listemployee[a].Name();
                    string apellido = listemployee[a].Lastname();
                    string nacimiento = listemployee[a].Datebirth();
                    string nacionalidad = listemployee[a].Nationality();

                    listemployee.RemoveAt(a);
                    Employee em = new Employee(trabajo, newsalary, horario, rut, nombre, apellido, nacimiento, nacionalidad);
                    listemployee.Insert(a, em);

                    Console.WriteLine("El sueldo del empleado: " + rut + " - " + nombre + " " + apellido + "\n Cambió de : " + salario + " a " + newsalary);
                    return true;
                }
                else
                {
                    a++;

                }

            }
            Console.WriteLine("El empleado no existe");
            return false;

        }
        public bool Cambiarhorario(string newtimetable, string rut)
        {
            for (int a = 0; a < listemployee.Count;)
            {
                if (listemployee[a].Rut() == rut)
                {
                    string trabajo = listemployee[a].Job();
                    int salario = listemployee[a].Salary();
                    string horario = listemployee[a].Timetable();
                    string nombre = listemployee[a].Name();
                    string apellido = listemployee[a].Lastname();
                    string nacimiento = listemployee[a].Datebirth();
                    string nacionalidad = listemployee[a].Nationality();

                    listemployee.RemoveAt(a);
                    Employee em = new Employee(trabajo, salario, newtimetable, rut, nombre, apellido, nacimiento, nacionalidad);
                    listemployee.Insert(a, em);

                    Console.WriteLine("El horario del empleado: " + rut + " - " + nombre + " " + apellido + "\n Cambió de : " + horario + " a " + newtimetable);
                    return true;
                }
                else
                {
                    a++;

                }

            }
            Console.WriteLine("El empleado no existe");
            return false;
        }
        

    }
}
