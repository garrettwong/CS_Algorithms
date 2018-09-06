
using System;
using System.Collections;

namespace csharpAlgorithms.Enumerators
{
    public class BasicPerson
    {
        public BasicPerson(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }

        public string FirstName;
        public string LastName;
    }

    public class People : IEnumerable
    {
        private BasicPerson[] _people;
        public People(BasicPerson[] pArray)
        {
            _people = new BasicPerson[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                _people[i] = pArray[i];
            }
        }

        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(_people);
        }
    }

    public class PeopleEnum : IEnumerator
    {
        private BasicPerson[] _people;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public PeopleEnum(BasicPerson[] people)
        {
            _people = people;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public BasicPerson Current
        {
            get
            {
                try
                {
                    return _people[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }


        public bool MoveNext()
        {
            position++;
            return (position < _people.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
