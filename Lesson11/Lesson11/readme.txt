### **Bài toán: Quản lý đặt phòng khách sạn**
1. Khách hàng có thể đặt các loại phòng khác nhau: Phòng Standard, Deluxe, Suite.
2. Mỗi loại phòng có giá khác nhau và có thể có các dịch vụ đi kèm như bữa sáng, Wi-Fi, hoặc dịch vụ đưa đón.
3. Hệ thống cần linh hoạt trong việc thêm loại phòng mới hoặc thay đổi cách tính giá mà không làm ảnh hưởng đến cấu trúc hiện tại.
4. Yêu cầu: Áp dụng nguyên lý SOLID và một số design patterns.

Room: cha
- StandardRoom: con
- DeluxeRoom: con
- SuiteRoom: con

-Booking, PticingCalculator
 Factory: cho việc tạo ra các loại phòng
 Strategy: cho việc tính giá

- Single Responsibility Principle (SRP):
	Mỗi lớp có một nhiệm vụ duy nhất, ví dụ: Lớp Room chỉ chịu trách nhiệm lưu thông tin phòng, lớp PriceCalculator chịu trách nhiệm tính giá.
- Open/Closed Principle (OCP):
	Có thể thêm loại phòng hoặc dịch vụ mới mà không cần sửa đổi mã hiện có.
- Liskov Substitution Principle (LSP):
	Các lớp con như StandardRoom, DeluxeRoom có thể thay thế lớp cha Room mà không ảnh hưởng đến logic của chương trình.
- Interface Segregation Principle (ISP):
	Sử dụng các interface nhỏ, ví dụ: IBookable cho việc đặt phòng, IPricable cho tính giá.
- Dependency Inversion Principle (DIP):
	Hệ thống phụ thuộc vào abstraction (IRoom, IPricingStrategy) thay vì các lớp cụ thể.



	-------------------------
	SOLID  - 5 nguyên lý áp cho phát triển các bài toán có sử dụng OOP
	- S ->Single Responsiblity Principle
		- 1 Class chỉ nên làm 1 việc
		Ví du: 1 class không nên vừa xử lý logic mà vừa thực hiện lưu dữ liệu
	- O -> Open/Close Principle
		- Open => cho việc mở rộng class (exten)
		- Close => đóng với việc sửa đổi class
		=> Nếu cần thêm chức năng thì ko nên sửa đổi class hiện tại mà nên mở rộng nó
	- L => 
		Class con kế thừa class cha, class con thay thế class cha mà ko phá vỡ logic
	- I  => Interface 
		 => không nên triển khai interface thừa => nôm na: class ko nên ép implementation (triển khai) các phương thức mà class đó ko sử dung
		=> nếu 1 interface quá lớn, chứa những phương thức mà ko phải class cũng dùng thì
		=> chia nhỏ interface
	- D => DIP
		=> class A Không nên phụ thuộc vào class B
		mà cả 2 class nên phụ thuộc vào abstraction
		=> phụ thuộc abstraction thay vì phụ thuộc vào các class cụ thể



