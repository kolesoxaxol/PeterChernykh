﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_Homework22122019
{
    public class Teacher
    {
        public void NewTeacher()
        {
         Random rnd = new Random();
         int newTeacher = rnd.Next(1, 2);
           
         RoomKeeper teacher = new RoomKeeper();

            if (newTeacher == 1)
            {
                var addTeacher = new MaxStudent();
                teacher.Add(addTeacher);

                Console.WriteLine("The teacher is already in the room");
            }
            else
            {
                Console.WriteLine("There is no teacher in the room");
            }
        }
    }
}
