--SQL
CREATE OR REPLACE VIEW part_listing_form AS (
    SELECT 
        p.prt_no,
        p.prt_desc1,
        p.prt_desc2,
        p.prt_desc3,
        p.prt_sort,
        p.prt_type,
        pg.pgr_no,
        p.prt_upc,
        p.prt_location,
        p.prt_idx1_1,
        p.prt_idx1_2,
        p.prt_idx1_3,
        p.prt_idx1_4,
        p.prt_idx1_5,
        p.prt_idx2_1,
        p.prt_idx2_2,
        p.prt_idx2_3,
        p.prt_idx2_4,
        p.prt_idx2_5,
        p.prt_idx3_1,
        p.prt_idx3_2,
        p.prt_idx3_3,
        p.prt_idx3_4,
        p.prt_idx3_5,
		p.prt_active
    FROM part p 
    JOIN part_group pg ON p.pgr_id = pg.pgr_id 
    ORDER BY p.prt_no
)