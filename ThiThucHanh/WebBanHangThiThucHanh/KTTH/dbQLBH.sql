INSERT INTO tUser (Username, Password, LoaiUser)
VALUES ('admin', '123456', 0);
INSERT INTO tUser (Username, Password, LoaiUser)
VALUES ('customer', '123456', 1);

INSERT INTO tLoaiSP (MaLoai, Loai) 
VALUES 
('L001', N'Áo Thun'),
('L002', N'Quần Jean'),
('L003', N'Giày Sneaker');

INSERT INTO tDanhMucSP (MaSp, TenSp, ChatLieu, DacTinh, HangSx, NuocSx, ThoiGianBaoHanh, AnhDaiDien, Gia, MaLoai, GioiThieuSp)
VALUES 
('SP001', N'Áo Thun Basic', N'Cotton', N'Mềm', N'Việt Nam', N'Việt Nam', 12, N'https://bizweb.dktcdn.net/thumb/grande/100/415/697/products/ap001.png?v=1701403328933', 120000, 'L001', N'Áo thun basic, chất liệu cotton mềm mại, thoải mái cho người mặc.'),
('SP002', N'Áo Thun Oversize', N'Cotton', N'Thoáng mát', N'Việt Nam', N'Việt Nam', 12, N'https://bizweb.dktcdn.net/thumb/grande/100/415/697/products/ap001.png?v=1701403328933', 130000, 'L001', N'Áo thun oversize thoáng mát, phù hợp với phong cách trẻ trung.'),
('SP003', N'Áo Thun Regular', N'Polyester', N'Co giãn', N'Trung Quốc', N'Việt Nam', 6, N'https://bizweb.dktcdn.net/thumb/grande/100/415/697/products/ap001.png?v=1701403328933', 90000, 'L001', N'Áo thun regular, co giãn tốt, thoải mái cho mọi hoạt động.'),
('SP004', N'Áo Thun Có Cổ', N'Polyester', N'Thấm hút', N'Thái Lan', N'Việt Nam', 6, N'https://bizweb.dktcdn.net/thumb/grande/100/415/697/products/ap001.png?v=1701403328933', 100000, 'L001', N'Áo thun có cổ, thấm hút mồ hôi, thích hợp cho mùa hè.'),
('SP005', N'Áo Thun Trơn', N'Cotton', N'Dễ chịu', N'Việt Nam', N'Việt Nam', 12, N'https://bizweb.dktcdn.net/thumb/grande/100/415/697/products/ap001.png?v=1701403328933', 110000, 'L001', N'Áo thun trơn, dễ chịu và dễ phối đồ.'),
('SP006', N'Áo Thun Cổ Tròn', N'Spandex', N'Co giãn tốt', N'Trung Quốc', N'Việt Nam', 6, N'https://bizweb.dktcdn.net/thumb/grande/100/415/697/products/ap001.png?v=1701403328933', 115000, 'L001', N'Áo thun cổ tròn, co giãn tốt, thích hợp cho thể thao.'),
('SP007', N'Áo Thun Đen', N'Cotton', N'Nhẹ', N'Việt Nam', N'Việt Nam', 12, N'https://bizweb.dktcdn.net/thumb/grande/100/415/697/products/ap001.png?v=1701403328933', 105000, 'L001', N'Áo thun đen, nhẹ nhàng và thanh lịch.'),
('SP008', N'Áo Thun Trắng', N'Polyester', N'Bền', N'Thái Lan', N'Việt Nam', 6, N'https://bizweb.dktcdn.net/thumb/grande/100/415/697/products/ap001.png?v=1701403328933', 125000, 'L001', N'Áo thun trắng, bền bỉ và dễ phối hợp.'),
('SP009', N'Áo Thun Unisex', N'Cotton', N'Phong cách', N'Việt Nam', N'Việt Nam', 12, N'https://bizweb.dktcdn.net/thumb/grande/100/415/697/products/ap001.png?v=1701403328933', 135000, 'L001', N'Áo thun unisex, phù hợp với mọi lứa tuổi.'),
('SP010', N'Áo Thun Vải Dày', N'Cotton', N'Chắc chắn', N'Việt Nam', N'Việt Nam', 12, N'https://bizweb.dktcdn.net/thumb/grande/100/415/697/products/ap001.png?v=1701403328933', 140000, 'L001', N'Áo thun vải dày, chắc chắn và ấm áp.');


INSERT INTO tDanhMucSP (MaSp, TenSp, ChatLieu, DacTinh, HangSx, NuocSx, ThoiGianBaoHanh, AnhDaiDien, Gia, MaLoai, GioiThieuSp)
VALUES 
('SP011', N'Quần Jean Rách', N'Denim', N'Bền', N'Việt Nam', N'Việt Nam', 18, N'https://quanjeandep.com/images/thumbs/quan-jean-nam-co-dien-dang-dung-501-505s-11507.jpeg', 300000, 'L002', N'Quần jean rách, phong cách thời trang cá tính.'),
('SP012', N'Quần Jean Skinny', N'Denim', N'Co giãn', N'Trung Quốc', N'Trung Quốc', 12, N'https://quanjeandep.com/images/thumbs/quan-jean-nam-co-dien-dang-dung-501-505s-11507.jpeg', 250000, 'L002', N'Quần jean skinny, ôm sát, tôn dáng.'),
('SP013', N'Quần Jean Regular', N'Denim', N'Thoải mái', N'Việt Nam', N'Việt Nam', 12, N'https://quanjeandep.com/images/thumbs/quan-jean-nam-co-dien-dang-dung-501-505s-11507.jpeg', 270000, 'L002', N'Quần jean regular, dễ mặc và dễ phối đồ.'),
('SP014', N'Quần Jean Cao Cấp', N'Denim', N'Sang trọng', N'Thái Lan', N'Việt Nam', 24, N'https://quanjeandep.com/images/thumbs/quan-jean-nam-co-dien-dang-dung-501-505s-11507.jpeg', 320000, 'L002', N'Quần jean cao cấp, chất liệu tốt, bền bỉ.'),
('SP015', N'Quần Jean Lưng Cao', N'Cotton', N'Bền', N'Việt Nam', N'Việt Nam', 18, N'https://quanjeandep.com/images/thumbs/quan-jean-nam-co-dien-dang-dung-501-505s-11507.jpeg', 280000, 'L002', N'Quần jean lưng cao, thoải mái cho mọi hoạt động.'),
('SP016', N'Quần Jean Rách Gối', N'Denim', N'Phong cách', N'Trung Quốc', N'Việt Nam', 12, N'https://quanjeandep.com/images/thumbs/quan-jean-nam-co-dien-dang-dung-501-505s-11507.jpeg', 260000, 'L002', N'Quần jean rách gối, cá tính và nổi bật.'),
('SP017', N'Quần Jean Slim Fit', N'Denim', N'Co giãn', N'Việt Nam', N'Việt Nam', 18, N'https://quanjeandep.com/images/thumbs/quan-jean-nam-co-dien-dang-dung-501-505s-11507.jpeg', 290000, 'L002', N'Quần jean slim fit, thời trang và phong cách.'),
('SP018', N'Quần Jean Xám', N'Denim', N'Thời trang', N'Thái Lan', N'Việt Nam', 24, N'https://quanjeandep.com/images/thumbs/quan-jean-nam-co-dien-dang-dung-501-505s-11507.jpeg', 310000, 'L002', N'Quần jean màu xám, dễ phối đồ.'),
('SP019', N'Quần Jean Ống Suông', N'Denim', N'Bền', N'Việt Nam', N'Việt Nam', 18, N'https://quanjeandep.com/images/thumbs/quan-jean-nam-co-dien-dang-dung-501-505s-11507.jpeg', 330000, 'L002', N'Quần jean ống suông, phong cách thoải mái.'),
('SP020', N'Quần Jean Màu Xanh', N'Denim', N'Trẻ trung', N'Trung Quốc', N'Việt Nam', 24, N'https://quanjeandep.com/images/thumbs/quan-jean-nam-co-dien-dang-dung-501-505s-11507.jpeg', 340000, 'L002', N'Quần jean màu xanh, trẻ trung và năng động.');


INSERT INTO tDanhMucSP (MaSp, TenSp, ChatLieu, DacTinh, HangSx, NuocSx, ThoiGianBaoHanh, AnhDaiDien, Gia, MaLoai, GioiThieuSp)
VALUES 
('SP021', N'Sneaker Trắng', N'Vải', N'Nhẹ', N'Việt Nam', N'Việt Nam', 24, N'https://product.hstatic.net/1000143422/product/shadow_white_52493454696_giay_sneaker_ecco_nam__1__c796798a38d043b8a0b278e5e7447267_large.jpg', 700000, 'L003', N'Sneaker trắng, nhẹ và dễ phối đồ.'),
('SP022', N'Sneaker Đen', N'Vải', N'Mang phong cách', N'Việt Nam', N'Việt Nam', 24, N'https://product.hstatic.net/1000143422/product/shadow_white_52493454696_giay_sneaker_ecco_nam__1__c796798a38d043b8a0b278e5e7447267_large.jpg', 800000, 'L003', N'Sneaker đen, mang đến phong cách trẻ trung.'),
('SP023', N'Sneaker Nam', N'Da', N'Bền', N'Việt Nam', N'Việt Nam', 24, N'https://product.hstatic.net/1000143422/product/shadow_white_52493454696_giay_sneaker_ecco_nam__1__c796798a38d043b8a0b278e5e7447267_large.jpg', 700000, 'L003', N'Sneaker nam, bền bỉ và chất lượng.'),
('SP024', N'Sneaker Dáng Thể Thao', N'Da', N'Bền', N'Việt Nam', N'Việt Nam', 24, N'https://product.hstatic.net/1000143422/product/shadow_white_52493454696_giay_sneaker_ecco_nam__1__c796798a38d043b8a0b278e5e7447267_large.jpg', 800000, 'L003', N'Sneaker dáng thể thao, thoải mái cho người dùng.'),
('SP025', N'Sneaker Đen', N'Vải', N'Phong cách', N'Việt Nam', N'Việt Nam', 24, N'https://product.hstatic.net/1000143422/product/shadow_white_52493454696_giay_sneaker_ecco_nam__1__c796798a38d043b8a0b278e5e7447267_large.jpg', 750000, 'L003', N'Sneaker đen, phong cách thời trang cho mọi người.'),
('SP026', N'Sneaker Trắng', N'Da', N'Nhẹ nhàng', N'Trung Quốc', N'Việt Nam', 24, N'https://product.hstatic.net/1000143422/product/shadow_white_52493454696_giay_sneaker_ecco_nam__1__c796798a38d043b8a0b278e5e7447267_large.jpg', 720000, 'L003', N'Sneaker trắng, nhẹ nhàng cho mọi hoạt động.'),
('SP027', N'Sneaker Thể Thao Nam', N'Da', N'Chắc chắn', N'Việt Nam', N'Việt Nam', 24, N'https://product.hstatic.net/1000143422/product/shadow_white_52493454696_giay_sneaker_ecco_nam__1__c796798a38d043b8a0b278e5e7447267_large.jpg', 690000, 'L003', N'Sneaker thể thao nam, chắc chắn và bền bỉ.'),
('SP028', N'Sneaker Vải', N'Vải', N'Thiết kế đẹp', N'Trung Quốc', N'Việt Nam', 24, N'https://product.hstatic.net/1000143422/product/shadow_white_52493454696_giay_sneaker_ecco_nam__1__c796798a38d043b8a0b278e5e7447267_large.jpg', 650000, 'L003', N'Sneaker vải, thiết kế đẹp và tiện lợi.'),
('SP029', N'Sneaker Bóng Rổ', N'Da', N'Thể thao', N'Việt Nam', N'Việt Nam', 24, N'https://product.hstatic.net/1000143422/product/shadow_white_52493454696_giay_sneaker_ecco_nam__1__c796798a38d043b8a0b278e5e7447267_large.jpg', 850000, 'L003', N'Sneaker bóng rổ, hoàn hảo cho các hoạt động thể thao.'),
('SP030', N'Sneaker Màu Đỏ', N'Vải', N'Thời trang', N'Trung Quốc', N'Việt Nam', 24, N'https://product.hstatic.net/1000143422/product/shadow_white_52493454696_giay_sneaker_ecco_nam__1__c796798a38d043b8a0b278e5e7447267_large.jpg', 720000, 'L003', N'Sneaker màu đỏ, thời trang và nổi bật.');
