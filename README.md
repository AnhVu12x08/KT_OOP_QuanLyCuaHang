# ĐỀ KIỂM TRA MÔN LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG
Mã đề: 02
Thời gian làm bài: 75 Phút
Lưu ý: Sử dụng tài liệu khi làm bài thi: Không được

---

## Câu 1: 
### Xây dựng lớp ThietBi
| **ThietBi** --abstract class--                                                                                          |
| -------------------------------------------------------------------------------------------------------------------------- |
| #maTB: string
#tenTB: string
#namSX: int
#giaBan: double
#phanTramHH: double
+static tileThue: double |
| +PhiBaoHanh(): double --abstract--
+ChiPhi(): double
+ThueSX(): double
+LoiNhuan(): double
+Xuat(); void --virtual-- |

Thông tin của một thiết bị gia dụng gồm: mã thiết bị, tên thiết bị, năm sản xuất, giá bán, phần trăm hoa hồng. Hãy phân tích và xây dựng lớp cho chương trình quản lý và tính lợi nhuận cho công ty. Biết rằng:

**Lợi nhuận = Giá bán – Chi phí – Thuế sản xuất**

Trong đó:
- **Thuế sản xuất** được tính bằng **Giá bán * Tỉ lệ thuế** (Tỉ lệ thuế là được áp dụng chung cho tất cả các cuốn sách và hiện tại đang được qui định là 10%).
- **Chi phí** được tính bằng **Phần trăm hoa hồng * Giá bán + Phí bảo hành**.

### Xây dựng lớp ThietBi với các yêu cầu sau:
1. Các thuộc tính theo mô tả ở trên.
2. Property cho thuộc tính Mã thiết bị, biết rằng Mã thiết bị phải bắt đầu bằng “TB" và theo sau là 3 ký tự số. Nếu không không thỏa thì mặc định Mã thiết bị là “TB001”.
3. Property cho giá bán, biết rằng giá bán luôn lớn hơn hoặc bằng 0.
4. Phương thức khởi tạo mặc định tạo ra một thiết bị có mã là “TB001”, tên thiết bị là “Máy xúc đất”, năm sản xuất là năm hiện tại, giá bán 10000 và hoa hồng là 4%.
5. Phương thức khởi tạo đầy đủ tham số.
6. Các phương thức xử lý cho yêu cầu tính thành tiền.
7. Phương thức xuất thông tin của mỗi thiết bị và lợi nhuận.

## Câu 2: Quản lý Phí bảo hành và Hỗ trợ Nhà nước

### Loại thiết bị và Phí bảo hành:

Thiết bị trong ứng dụng này được chia thành 3 loại, và mỗi loại có cách tính Phí bảo hành khác nhau:

1. **Thiết bị điện tử:**
    - Bổ sung thông tin về thời gian bảo hành (số tháng).
    - Phí bảo hành được tính như sau: nếu số tháng bảo hành > 24 tháng, thì phí bảo hành là 10% giá bán, ngược lại là 8% giá bán.

2. **Thiết bị gia dụng:**
    - Bổ sung thông tin về chất liệu (String).
    - Nếu chất liệu là "nhựa", thì phí bảo hành bằng 0.
    - Đối với các chất liệu khác, phí bảo hành là 15% giá bán, nhưng không được lớn hơn 10,000 đơn vị tiền tệ.

3. **Thiết bị giáo dục:**
    - Là các thiết bị dùng phục vụ cho các hoạt động giáo dục.
    - Bổ sung thông tin về tuổi của đối tượng sử dụng.
    - Nếu thiết bị dành cho tuổi nhỏ hơn 10, thì không có phí bảo hành.
    - Ngược lại, phí bảo hành là 10% giá bán nếu năm sản xuất nhỏ hơn 2020, ngược lại là 18% giá bán.

### Hỗ trợ từ Nhà nước:

Nhà nước hỗ trợ người dùng khi mua thiết bị gia dụng và thiết bị điện tử như sau:

1. **Thiết bị điện tử:**
    - Nếu giá bán lớn hơn 100,000 đơn vị tiền tệ, thì Nhà nước hỗ trợ 3% giá bán.
    - Ngược lại, hỗ trợ 2% giá bán.

2. **Thiết bị gia dụng:**
    - Mỗi sản phẩm được hỗ trợ 40,000 đơn vị tiền tệ.

### Yêu cầu:

1. **Vẽ Sơ đồ lớp:** Hãy vẽ sơ đồ lớp thể hiện quan hệ kế thừa giữa các lớp trong ứng dụng quản lý.

2. **Cài đặt các lớp:** Cài đặt các lớp theo mô hình thiết kế trên, bao gồm các phương thức và thuộc tính đã mô tả trong đề.
