﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Группа
    /// </summary>
    public class MGroup : Model
    {
        /// <summary>
        /// Перечисление полей объекта модели Группа
        /// </summary>
        public enum Keys { Id = 0, Cipher = 1, Population = 2 }

        string cipher;
        /// <summary>
        /// численность
        /// </summary>
        byte population;
        /// <summary>
        /// Создает экземпляр
        /// </summary>
        /// <param name="cipher">шифр</param>
        /// <param name="population">численность</param>
        public MGroup(string cipher, byte population):base()
        {
            Cipher = cipher;
            Population = population;
        }
        /// <summary>
        /// Возвращает значение перечисления
        /// </summary>
        /// <param ключ="key"></param>
        /// <returns></returns>
        public object this[Keys key]
        {
            get
            {
                switch (key)
                {
                    case Keys.Id: return Id;
                    case Keys.Population: return Population;
                    case Keys.Cipher: return Cipher;
                    default: return null;
                }
            }
        }
        /// <summary>
        /// Возвращает или задает шифр группы
        /// </summary>
        public string Cipher
        {
            get
            {
                return cipher;
            }

            set
            {
                cipher = value;
            }
        }
        /// <summary>
        /// Возвращает или задает численность группы
        /// </summary>
        public byte Population
        {
            get
            {
                return population;
            }

            set
            {
                population = value;
            }
        }
    }
}