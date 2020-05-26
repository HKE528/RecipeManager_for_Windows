using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    class RecipeData
    {
        private string _name;
        private string _category;
        private string _level;
        private string _time;
        private List<string> _mainFood;
        private List<string> _subFood;
        private List<string> _content;

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }
        public string level
        {
            get
            {
                return _level;
            }
            set
            {
                _level = value;
            }
        }
        public string time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
            }
        }

        public List<string> mainFood
        {
            get
            {
                return _mainFood;
            }
            set
            {
                _mainFood = value;
            }
        }
        public List<string> subFood
        {
            get
            {
                return _subFood;
            }
            set
            {
                _subFood = value;
            }
        }
        public List<string> content
        {
            get
            {
                return _content;
            }
            set
            {
                _content = value;
            }
        }
    }
}
