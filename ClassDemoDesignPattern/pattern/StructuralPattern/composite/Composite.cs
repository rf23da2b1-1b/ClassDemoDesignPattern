﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassDemoDesignPatterns.pattern.StructuralPattern.composite
{
    public class Composite:IComponent
    {
        // Make the 'composite' list,add,remove
        private List<IComponent> liste;

        public Composite()
        {
            liste = new List<IComponent>();
        }

        public void Add(IComponent component)
        {
            liste.Add(component);
        }

        public void Remove(IComponent component)
        {
            liste.Remove(component);
        }

        //public int Weight { get; }

        public int TotalWeight()
        {
            return liste.Sum(c => c.TotalWeight());
        }
    }
}
