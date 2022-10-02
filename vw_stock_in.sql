DELIMITER $$

ALTER ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_stock_in_history` AS (
SELECT
  `stock_in`.`stock_in_id`   AS `stock_in_id`,
  `stock_in`.`ref_no`        AS `ref_no`,
  `stock_in`.`trans_date`    AS `trans_date`,
  `branch`.`branch_address`  AS `branch_address`,
  `item`.`item_code`         AS `item_code`,
  `brand`.`brand_name`       AS `brand_name`,
  `item`.`item_desc`         AS `item_desc`,
  `item`.`item_add_desc`     AS `item_add_desc`,
  `category`.`category_name` AS `category_name`,
  `unit`.`unit_name`         AS `unit_name`,
  `stock_in`.`qty`           AS `qty`,
  `supplier`.`supplier_name` AS `supplier_name`,
  `stock_in`.`remarks`       AS `remarks`
FROM (((((((`inventory`
         JOIN `item`
           ON (`item`.`item_id` = `inventory`.`item_id`))
        JOIN `brand`
          ON (`brand`.`brand_id` = `item`.`brand_id`))
       JOIN `category`
         ON (`category`.`category_id` = `item`.`category_id`))
      JOIN `stock_in`
        ON (`stock_in`.`inventory_id` = `inventory`.`inventory_id`))
     JOIN `supplier`
       ON (`supplier`.`supplier_id` = `stock_in`.`supplier_id`))
    JOIN `branch`
      ON (`branch`.`branch_id` = `stock_in`.`branch_id`))
   JOIN `unit`
     ON (`unit`.`unit_id` = `item`.`unit_id`)))$$

DELIMITER ;