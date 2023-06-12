# Code

```c#
private int americanohcoun = 0, cafelattehcoun = 0, cappuccinohcoun = 0, cafemochahcoun = 0, caramelhcoun = 0, americanoicoun = 0, cafelatteicoun = 0, cappuccinoicoun = 0, cafemochaicoun = 0, caramelicoun = 0, chococakecoun = 0, cheezecakecoun = 0, browniecoun = 0, tiramisucoun = 0, muffincoun = 0, bagelcoun = 0, wafflecoun = 0;
        private string[] name = new string[50]; // sales 파일에 Stockname 저장
        private Int32[] count = new Int32[50]; // sales 파일에 Stockcount 저장
        private string[] note = new string[50];// sales 파일에 Stocknote 저장
        private int i = 0; // 데이터베이스 파일을 읽어 안에 필드들을 저장할때 그 수만큼 카운트 해주는 변수
        string stockfile = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=stock.mdb";
       
        // count 배열에 대한 인덱스
        public Int32 this[int index]
        { 
            get { return count[index]; }
            set { count[index] = value; }
        }
```
