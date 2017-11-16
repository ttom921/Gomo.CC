//這是mssql
加入以下的package
Install-Package Microsoft.EntityFrameworkCore.SqlServer
nstall-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design
注意目前的db first 只支援單一專案
//Scaffold-DbContext "Data Source=DESKTOP-NITSS8T;Initial Catalog=Blogging;User ID=sa;Password=12345678;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
//注意要先卸載所有的專案只剩下model的專案，才能執行下列的專案
Scaffold-DbContext -Connection "Server=(local);Database=Gomo.CCDb;User ID=sa;Password=12345678;" -Context "GomoCCDBContext"  -Provider Microsoft.EntityFrameworkCore.SqlServer -OutputDir "" -Project Gomo.CC.Model  -force 

//這是mysql
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design
Install-Package Pomelo.EntityFrameworkCore.MySql
Install-Package Pomelo.EntityFrameworkCore.MySql.Design
//注意目前的db first 只支援單一專案
注意要先卸載所有的專案只剩下model的專案，才能執行下列的專案
Scaffold-DbContext -Connection "Server=192.168.2.150;Database=Gomo.CCDb;User ID=gomo2o-shop;Password=Gomo2OShop123;" -Context "GomoCCDBContext"  -Provider Pomelo.EntityFrameworkCore.MySql -OutputDir "" -Project Gomo.CC.Model  -force -verbose

系統會DI 所以DBContext要改寫，
1.Delete the OnConfiguring(...) method
2.加入constructor
 public GomoCCDBContext(DbContextOptions<GomoCCDBContext> options)
            : base(options)
        { }
3.處理下列的問題
  JsonObject 轉換成 JsonObject<string>