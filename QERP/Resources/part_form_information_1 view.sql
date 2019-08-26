--SQL
CREATE OR REPLACE VIEW part_form_information_1 AS (
    SELECT
        p.prt_no,
        p.prt_desc1,
        p.prt_desc2,
        p.prt_desc3,
        pg.pgr_no,
        pg.pgr_desc,
        (
            SELECT sup_no 
            FROM part_supplier 
            WHERE psp_idx = p.prt_def_sup_idx 
            AND prt_id = p.prt_id
        ),
        (
            SELECT sup_name1 
            FROM supplier 
            WHERE sup_no IN 
            (
                SELECT sup_no 
                FROM part_supplier 
                WHERE psp_idx = p.prt_def_sup_idx 
                AND prt_id = p.prt_id
            )
        ),
        p.prt_sort,
        CASE
            WHEN p.prt_type = 'A' THEN 'Purchased'
            WHEN p.prt_type = 'F' THEN 'Manufactured'
        END AS prt_type,
        CASE
            WHEN p.prt_directed_to = 'A' THEN 'Purchasing'
            WHEN p.prt_directed_to = 'P' THEN 'Production'
        END AS prt_directed_to,
        p.prt_finished,
        p.prt_location,
        CASE
            WHEN p.prt_taxable = 0 THEN 'Taxable'
            WHEN p.prt_taxable = 1 THEN 'Not Taxable'
            WHEN p.prt_taxable = 2 THEN 'According to Group'
        END AS prt_taxable,
        p.prt_demo_qty,
        p.prt_repair_qty
        
    FROM part p
    JOIN part_group pg ON p.pgr_id = pg.pgr_id
);