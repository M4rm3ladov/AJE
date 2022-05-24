DELIMITER $$

ALTER ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_stock_ret_history` AS (
SELECT
  `stock_return`.`stock_ret_id` AS `stock_ret_id`,
  `stock_return`.`trans_date`   AS `trans_date`,
  `stock_return`.`ref_no`       AS `ref_no`,
  `item`.`item_code`            AS `item_code`,
  `brand`.`brand_name`          AS `brand_name`,
  `item`.`item_desc`            AS `item_desc`,
  `item`.`item_add_desc`        AS `item_add_desc`,
  `category`.`category_name`    AS `category_name`,
  `unit`.`unit_name`            AS `unit_name`,
  `stock_return`.`qty`          AS `qty`,
  `supplier`.`supplier_name`    AS `supplier_name`,
  `branch`.`branch_address`     AS `branch_address`,
  `stock_return`.`remarks`       AS `remarks`
FROM (((((((`inventory`
         JOIN `item`
           ON (`item`.`item_id` = `inventory`.`item_id`))
        JOIN `brand`
          ON (`brand`.`brand_id` = `item`.`brand_id`))
       JOIN `category`
         ON (`category`.`category_id` = `item`.`category_id`))
      JOIN `stock_return`
        ON (`stock_return`.`inventory_id` = `inventory`.`inventory_id`))
     JOIN `supplier`
       ON (`supplier`.`supplier_id` = `stock_return`.`supplier_id`))
    JOIN `branch`
      ON (`branch`.`branch_id` = `inventory`.`branch_id`))
   JOIN `unit`
     ON (`unit`.`unit_id` = `item`.`unit_id`)))$$

DELIMITER ;