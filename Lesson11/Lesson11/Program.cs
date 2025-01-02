// Áp dụng Factory Pattern: đóng gói quá trình khởi tạo đội tượng
// 1 - tạo ra các đối tượng mà ko cần show ra logic khởi tạo cụ thể của đối tượng đấy
// 2 - dễ dàng mở rộng khi có thêm loại đối tượng mới

using Lesson11.Factory;
using Lesson11.Interface;
using Lesson11;

IRoom room = RoomFactory.CreateRoom("Deluxe");

// Strategy 
// Cach tinh gia mac dinh
IPricingStrategy pricingStrategy1 = new DefaultPricingStrategy();

// cach tinh moi
IPricingStrategy pricingStrategy2 = new DiscountPricingStrategy();

Booking booking = new Booking(room, pricingStrategy2, includesBreakfast: true, includesWiFi: true);
booking.PrintBookingDetails();