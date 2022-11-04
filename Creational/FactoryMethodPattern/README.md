Tổng quan:

Factory Pattern là một trong những Pattern thuộc nhóm Creational Design Pattern.
Nhiệm vụ của Factory Pattern là quản lý và trả về các đối tượng theo yêu cầu, giúp cho việc khởi tạo đổi tượng một cách linh hoạt hơn.

Vấn đề:

Giả sử bạn đang tạo ra một ứng dụng quản lý trong mảng logistics. Phiên bản đầu tiên của ứng dụng chỉ có thể xử lý việc vận chuyển bằng xe tải, vì vậy phần lớn code của bạn nằm trong `class Truck`.
Sau một thời gian, ứng dụng của bạn trở nên khá phổ biến. Mỗi ngày bạn nhận được hàng chục yêu cầu từ các công ty vận tải đường biển để kết hợp đường biển vào ứng dụng.

Amazing, good job !!! Nhưng làm thế nào để triển khai vào ứng dụng ? 

Hiện tại, hầu hết code của bạn được xử lý cùng với `class Truck`. Thêm `class Ship` vào ứng dụng sẽ phải thay đổi toàn bộ code.
Hơn nữa, nếu sau này bạn quyết định thêm loại phương tiện vận tải khác vào ứng dụng, có thể bạn sẽ cần thực hiện tất cả những thay đổi này một lần nữa. 

Kết quả là bạn sẽ nhận được một đoạn code khá rắc rối với các logic chuyển đổi tùy thuộc vào lớp đối tượng giao thông vận tải.

Cách giải quyết:

Factory Method khuyến khích chúng ta nên thay thế phương thức khởi tạo `contructor` của đối tượng bằng cách gọi đến một phương thức khác, có thể gọi là `factory method`.  Đối tượng được tạo từ `factory method` được gọi là `product`.

Thoạt nhìn, chúng ta chỉ thay đổi phương thức khởi tạo `contructor` của đối tượng bằng một phương thức. 
Tuy nhiên bây giờ bạn có thể ghi đè `factory method` trong class con và thay đổi class `product` được tạo ra bởi `factory method`. 
Vì vậy chúng ta có thể tạo ra các `product` khác nhau, chỉ khi các `product` này đều điểm chung là được kế thừa từ lớp abstract hoặc interface. Ngoài ra, `factory method` trong lớp abstract nên có kiểu trả về được khai báo là interface.