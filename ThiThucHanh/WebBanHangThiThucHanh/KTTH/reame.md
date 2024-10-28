*) Build dự án sau đó:
- Vào file QLBHContext.cs(KTTH>Models) và file appsettings.json để đổi chuỗi kết nối của sever máy bạn
- vào nuget console gõ: "Add-Migration InitialCreate" và sau đó gõ "Update-Database"
để tạo db. Hoặc mở terminal, powershell gõ "dotnet ef migrations add InitialCreate" , sau đó gõ "dotnet ef database update"

*)chạy file sql với sql sever để tạo dữ liệu

*)Đăng nhập tài khoản 
Admin:
- user:admin
- pass:123456
Customer:
- user:customer
- pass:123456

