DELIMITER $$

ALTER ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_stock_out_history` AS (
SELECT
  `stock_out`.`stock_out_id` AS `stock_out_id`,
  `stock_out`.`trans_date`   AS `trans_date`,
  `stock_out`.`ref_no`       AS `ref_no`,
  `branch`.`branch_address`  AS `branch_address`,
  `item`.`item_code`         AS `item_code`,
  `brand`.`brand_name`       AS `brand_name`,
  `item`.`item_desc`         AS `item_desc`,
  `item`.`item_add_desc`     AS `item_add_desc`,
  `category`.`category_name` AS `category_name`,
  `unit`.`unit_name`         AS `unit_name`,
  `stock_out`.`qty`          AS `qty`,
  `stock_out`.`remarks`       AS `remarks`
FROM ((((((`inventory`
        JOIN `item`
          ON (`item`.`item_id` = `inventory`.`inventory_id`))
       JOIN `brand`
         ON (`brand`.`brand_id` = `item`.`brand_id`))
      JOIN `category`
        ON (`category`.`category_id` = `item`.`category_id`))
     JOIN `stock_out`
       ON (`stock_out`.`inventory_id` = `inventory`.`inventory_id`))
    JOIN `branch`
      ON (`branch`.`branch_id` = `inventory`.`branch_id`))
   JOIN `unit`
     ON (`unit`.`unit_id` = `item`.`unit_id`)))$$

DELIMITER ;