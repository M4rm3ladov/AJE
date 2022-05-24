DELIMITER $$

ALTER ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_stock_adjust_history` AS (
SELECT
  `physical_count`.`phys_count_id` AS `phys_count_id`,
  `physical_count`.`count_date`    AS `count_date`,
  `item`.`item_code`               AS `item_code`,
  `brand`.`brand_name`             AS `brand_name`,
  `item`.`item_desc`               AS `item_desc`,
  `item`.`item_add_desc`           AS `item_add_desc`,
  `category`.`category_name`       AS `category_name`,
  `unit`.`unit_name`               AS `unit_name`,
  `branch`.`branch_address`        AS `branch_address`,
  `physical_count`.`qty`           AS `qty`,
  `physical_count`.`ref_no`        AS `ref_no`,
  `inventory_period`.`period_from` AS `period_from`,
  `inventory_period`.`period_to`   AS `period_to`,
  `physical_count`.`remarks`       AS `remarks`
FROM (((((((`inventory`
         JOIN `physical_count`
           ON (`physical_count`.`inventory_id` = `inventory`.`inventory_id`))
        JOIN `inventory_period`
          ON (`inventory_period`.`inv_period_id` = `physical_count`.`inv_period_id`))
       JOIN `item`
         ON (`item`.`item_id` = `inventory`.`item_id`))
      JOIN `brand`
        ON (`brand`.`brand_id` = `item`.`brand_id`))
     JOIN `category`
       ON (`category`.`category_id` = `item`.`category_id`))
    JOIN `unit`
      ON (`unit`.`unit_id` = `item`.`unit_id`))
   JOIN `branch`
     ON (`branch`.`branch_id` = `inventory`.`branch_id`)))$$

DELIMITER ;