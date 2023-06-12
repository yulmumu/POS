# Code

```c#
private int americanohcoun = 0, cafelattehcoun = 0, cappuccinohcoun = 0, cafemochahcoun = 0, caramelhcoun = 0, americanoicoun = 0, cafelatteicoun = 0, cappuccinoicoun = 0, cafemochaicoun = 0, caramelicoun = 0, chococakecoun = 0, cheezecakecoun = 0, browniecoun = 0, tiramisucoun = 0, muffincoun = 0, bagelcoun = 0, wafflecoun = 0;
        private string[] name = new string[50]; // sales 파일에 Stockname 저장
        private Int32[] count = new Int32[50]; // sales 파일에 Stockcount 저장
        private string[] note = new string[50];// sales 파일에 Stocknote 저장
        private int i = 0; //정수형 변수로, 데이터베이스 파일을 읽어와서 필드를 저장할 때 저장한 필드의 수를 카운트. 
        이는 name, count, note 배열에 저장된 요소의 수를 추적하는 데 사용됩니다.
        string stockfile = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=stock.mdb"; //문자열 변수로, 데이터베이스 파일에 대한 연결 문자열을 저장
       
        // count 배열에 대한 인덱스
        public Int32 this[int index] //클래스 외부에서 count 배열에 접근하여 값을 읽거나 수정
        { 
            get { return count[index]; }
            set { count[index] = value; }
        }
```
```c#
public void Stockopen() // sales 파일에 내용을 배열에 저장하는 메소드
        {
            string aaa = "select * from stock"; //메소드 내에서 "aaa"라는 문자열에 "stock" 테이블에서 모든 열을 선택하는 SQL 쿼리가 저장
            OleDbConnection stockconn = new OleDbConnection(stockfile);
            stockconn.Open();
            OleDbCommand stockcomm = new OleDbCommand(aaa, stockconn);
            OleDbDataReader sr = stockcomm.ExecuteReader();
            while (sr.Read()) //while 루프를 사용하여 "sr.Read()"가 참인 동안 반복
            {
                name[i] = sr.GetString(0);
                count[i] = sr.GetInt32(1);
                note[i] = sr.GetString(2);
                i++; //"i" 값을 증가시켜 다음 인덱스 위치로 이동
            }
            sr.Close();
            stockconn.Close();
        }
        ```
