SELECT
  stock_transfer.stock_trans_id ,
  stock_transfer.ref_no         ,
  stock_transfer.trans_date     ,
  b_from.branch_address  AS b_from,
  b_to.branch_address  AS b_to,
  item.item_code                ,
  brand.brand_name              ,
  item.item_desc                ,
  item.item_add_desc            ,
  category.category_name        ,
  unit.unit_name                ,
  stock_transfer.qty            ,
  stock_transfer.remarks        
FROM inventory
INNER JOIN stock_transfer ON stock_transfer.inventory_id = inventory.inventory_id
INNER JOIN item ON item.item_id = inventory.item_id
INNER JOIN brand ON brand.brand_id = item.brand_id
INNER JOIN branch AS b_from ON b_from.branch_id = stock_transfer.branch_id_from
INNER JOIN branch AS b_to ON b_to.branch_id = stock_transfer.branch_id_to
INNER JOIN category ON category.category_id = item.category_id
INNER JOIN unit ON unit.unit_id = item.unit_id