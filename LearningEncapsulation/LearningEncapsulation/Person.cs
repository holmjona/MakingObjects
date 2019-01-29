using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEncapsulation {
    class Person {
        #region Private Variables
        private String _FirstName = "Frank";
        #endregion

        #region Public Properties
        public String FirstName {
            get {
                return _FirstName;
            }
            set {
                _FirstName = value;
            }
        }
        #endregion
    }
}
