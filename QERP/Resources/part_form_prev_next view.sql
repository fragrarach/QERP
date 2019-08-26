--SQL
CREATE OR REPLACE VIEW part_form_prev_next AS (
    SELECT 
        prt_no, 
        LAG(prt_no) over (ORDER BY prt_no ASC) AS prev_prt_no,
        LEAD(prt_no) over (ORDER BY prt_no ASC) AS next_prt_no
    FROM part 
    ORDER BY prt_no ASC
);