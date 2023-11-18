using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace masSeminary
{
    internal class Task2
    {
        public List<int> Union { get; }
        public List<int> Intersection { get; }
        public List<int> Difference { get; }

        public Task2(int[] first, int[] second)
        {
            Union = new List<int>();
            Intersection = new List<int>();
            Difference = new List<int>();

            UnionMassive(first, second);
            IntersectionMassive(first, second);
            DifferenceMassive(first, second);
        }

        private void AddSmallerElement (ref int ind, int[] mas)
        {
            if (Union.Count == 0 || Union.Last() != mas[ind])
                Union.Add(mas[ind]);

            if (ind < mas.Length - 1) ind++;
        }

        private void UnionMassive(int[] first, int[] second)
        {
            var fIndex = 0; var sIndex = 0;
            for (var i = 0; i < (first.Length + second.Length); i++)
            {
                if (first[fIndex] < second[sIndex])
                    AddSmallerElement(ref fIndex, first);
                else if (second[sIndex] < first[fIndex])
                    AddSmallerElement(ref sIndex, second);
                else
                {
                    AddSmallerElement(ref fIndex, first);
                    if (sIndex < second.Length - 1) sIndex++;
                    i++;
                }
            }
        }

        private void IntersectionMassive(int[] first, int[] second)
        {
            var fIndex = 0; var sIndex = 0;
            for (var i = 0; i < first.Length + second.Length; i++)
            {
                if (first[fIndex] < second[sIndex] && fIndex < first.Length - 1)
                    fIndex++;
                else if (second[sIndex] < first[fIndex] && sIndex < second.Length - 1)
                    sIndex++;
                else
                {
                    if (Intersection.Count == 0 || Intersection.Last() != first[fIndex])
                        Intersection.Add(first[fIndex]);
                    if (fIndex < first.Length - 1) fIndex++;
                    if (sIndex < second.Length - 1) sIndex++;
                    i++;
                }
            }
        }

        private void DifferenceMassive(int[] first, int[] second)
        {
            var fIndex = 0; var sIndex = 0;
            for (var i = 0; i < first.Length + second.Length; i++)
            {
                if (first[fIndex] < second[sIndex])
                {
                    Difference.Add(first[fIndex]);
                    if (fIndex < first.Length - 1) fIndex++;
                }
                else if (first[fIndex] > second[sIndex] && sIndex < second.Length - 1)
                    sIndex++;
                else
                {
                    if (fIndex < first.Length - 1) fIndex++;
                    if (sIndex < second.Length - 1) sIndex++;
                    i++;
                }
            }
        }
    }
}
