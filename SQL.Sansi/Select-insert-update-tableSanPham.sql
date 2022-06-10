SELECT * FROM SanPham

-- Insert rows into table 'TableName' in schema '[dbo]'
INSERT INTO [dbo].[sanpham]
( -- Columns to insert data into
 [TenSanPham], [GiaSanPham], [UrlImage],[TYPE]
)
VALUES
( 'home', null, '/images/Danh-muc-sp/03_Home-1-4 (2).jpg',3),
('Sexy Dresses', 12.1, '/images/Danh-muc-sp/03_Home-1-4 (2).jpg',3),
('Sexy Dresses', 14.2, '/images/Danh-muc-sp/Rectangle 6.1 (2).jpg',3),
('Sexy Dresses',15.2, '/images/Danh-muc-sp/Rectangle 6.2 (2).jpg',3),
('Sexy Dresses', 22.2, '/images/Danh-muc-sp/Rectangle 6.3 (2).jpg',3)
-- Add more rows here
GO

-- Update rows in table '[TableName]' in schema '[dbo]'
UPDATE [dbo].[sanpham]
SET
    -- [TenSanPham] = 'Sexy Dresses',
    -- [GiaSanPham]= 41.2,
    -- [UrlImage]='/images/Danh-muc-sp/Rectangle 6.jpg',
    [TYPE]=2
    -- Add more columns and values here
WHERE TYPE = 3 /* add search conditions here */
GO
