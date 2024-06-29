using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        private Builder _builder;

        public Director(Builder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.MakeTitle("Greeting");
            _builder.MakeString("一般的なあいさつ");
            _builder.MakeItems(new string[]
            {
                "How are you?",
                "Hello.",
                "Hi."
            });

            _builder.MakeString("時間帯に応じたあいさつ");
            _builder.MakeItems(new string[]
            {
                "Good morning.",
                "Good afternoon.",
                "Good evenig."
            });

            _builder.MakeString("お知らせ");
            _builder.MakeItems(new string[]
            {
                "2024年6月29日(土)にドーナツの新作が発売されます。",
            });
            _builder.Close();
        }
    }
}
