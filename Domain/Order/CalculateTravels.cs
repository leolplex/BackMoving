using Domain.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Order
{
    public class CalculateTravels
    {
        public List<Output> calculate(RawInfo rawInfo)
        {
            if (!validateConstrainsWorkDays(rawInfo.WorkDays))
            {
                return new List<Output>();
            }
            List<Output> outputs = new List<Output>();
            int startPosition = 0;
            for (int i = 0; i < rawInfo.WorkDays; i++)
            {

                if (!validateConstrainsElementsDay(rawInfo.ElementValue[startPosition]))
                    return new List<Output>();

                Output output = new Output();
                output.CaseDay = "Case #" + (i + 1);
                int endPosition = startPosition + rawInfo.ElementValue[startPosition];
                output.NumberMaxTravels = calculateMaxTravels((startPosition + 1), endPosition, rawInfo.ElementValue);
                outputs.Add(output);
                startPosition = endPosition + 1;

            }
            return outputs;
        }

        private bool validateConstrainsWorkDays(int workDays)
        {
            if (workDays < 1 || workDays > 500)
                return false;
            return true;
        }

        private bool validateConstrainsElementsDay(int workDays)
        {
            if (workDays < 1 || workDays > 100)
                return false;
            return true;
        }

        private bool validateConstrainElementValue(int elementValue)
        {
            if (elementValue < 1 || elementValue > 100)
                return false;
            return true;
        }

        private int calculateMaxTravels(int startPosition, int endPosition, List<int> elementValue)
        {
            List<int> elementsOrdered = orderElementsHigherToLower(startPosition, endPosition, elementValue);
            if (elementsOrdered.Count <= 0)
                return 0;
            int minimumAmountOfPounds = 50;
            int accumulator = 0;
            int until = (elementsOrdered.Count / 2);
            for (int i = 0; i < until; i++)
            {
                if (elementsOrdered[i] * 2 >= 50)
                {
                    accumulator++;
                }
                else
                {
                    int missingElements = (minimumAmountOfPounds / elementsOrdered[i]) / 2;
                    if (until - i >= missingElements)
                    {
                        accumulator++;
                    }
                    until = until - missingElements;
                }
            }

            return accumulator == 0 ? 1 : accumulator;
        }

        private List<int> orderElementsHigherToLower(int startPosition, int endPosition, List<int> elementValue)
        {
            List<int> temporalList = new List<int>();
            for (int i = startPosition; i < elementValue.Count; i++)
            {
                if (!validateConstrainElementValue(elementValue[i]))
                    return new List<int>();

                temporalList.Add(elementValue[i]);
                if (i == endPosition)
                {
                    break;
                }
            }

            temporalList.Sort(new SortIntDescending());
            return temporalList;
        }
    }

}
