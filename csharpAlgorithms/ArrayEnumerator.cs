using System;
using System.Collections;
using System.Collections.Generic;

namespace csharpAlgorithms
{
    public class ArrayEnumerator<T> : IEnumerator<T>
    {
        private T[] _arr;
        private int _curIndex;
        private T _curT;

        public ArrayEnumerator(T[] arr)
        {
            _arr = arr;
            _curIndex = -1;
            _curT = default(T);
        }

        public T Current
        {
            get
            {
                if (_arr == null || _curT == null)
                {
                    throw new InvalidOperationException();
                }

                return _curT;
            }
        }

        object IEnumerator.Current
        {
            get { return (object)this.Current; }
        }

        public bool MoveNext()
        {            
            _curIndex++;

            if(_curIndex >= _arr.Length) {
                _curT = default(T);
                return false;
            }
            
            _curT = _arr[_curIndex];
            
            if (EqualityComparer<T>.Default.Equals(_curT, default(T))) {
                return false;
            }

            return true;
        }

        public void Reset()
        {
            _curT = default(T);
            _curIndex = -1;
        }

        private bool disposedValue = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    // Dispose of managed resources.
                }
                _curT = default(T);
            }

            this.disposedValue = true;
        }
    }
}