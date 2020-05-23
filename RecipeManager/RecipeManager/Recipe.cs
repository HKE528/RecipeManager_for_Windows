using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    enum DataIndex
    {
        Name,
        Category,
        Level,
        Time,
        Main,
        Sub,
        RecipeStart
    };

    class Recipe
    {


        private List<List<string>> _recipeContent;
        private Dictionary<string, string> recipeTitle;

        public Recipe()
        {
            updateAllRecipeContents();
        }


        public List<List<string>> recipeContent
        {
            get
            {
                return _recipeContent;
            }
        }

        //레시피 파일 가져와 초기화
        private void updateAllRecipeContents()
        {
            _recipeContent = new FileIO().GetFileContent();
        }

        //조건 만족하는 레시피 반환
        public Dictionary<string, string> GetRecipeList(string category, int index)
        {
            recipeTitle = new Dictionary<string, string>();

            foreach (var recipe in _recipeContent)
            {
                string targetCategory = recipe[(int)DataIndex.Category].Split(',')[0];

                if (category != targetCategory && category != "전체")
                    continue;

                string name = recipe[(int)DataIndex.Name].Split('.')[0];
                string sub = index == 0 ? recipe[(int)DataIndex.Level].Split(',')[0] :
                    recipe[(int)DataIndex.Time].Split(',')[0];

                recipeTitle.Add(name, sub);
            }

            return recipeTitle;
        }
    }
}
