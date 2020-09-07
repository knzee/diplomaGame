using UnityEngine;

public class MovingSawController : WhirligigSawController
{
    [SerializeField]
    private float railsHeightMultuplier = 0.3f;
    [SerializeField]
    private float actionWidth = 2f;
    [SerializeField]
    private float moveSpeed = 0.01f;

    private float
        angle,
        sin,
        cos;

    private Vector2 startingPoint;
    private Vector2 destinationPoint;

    protected override void Start()
    {
        base.Start();

        CalcPoints();

        SetUpRails();
        
    }

    private void Update()
    {
        if (transform.position.x >= destinationPoint.x && transform.position.y >= destinationPoint.y ||
            transform.position.x <= startingPoint.x && transform.position.y <= startingPoint.y)
        {
            moveSpeed *= -1;
        }

        transform.position += new Vector3(moveSpeed * cos, moveSpeed * sin, 0f);
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }


    private void CalcPoints()
    {
        angle = transform.rotation.eulerAngles.z * Mathf.Deg2Rad;
        cos = Mathf.Abs(Mathf.Cos(angle));
        sin = Mathf.Abs(Mathf.Sin(angle));

        startingPoint = new Vector2(transform.position.x - actionWidth /2 * cos, transform.position.y - actionWidth /2 * sin);
        destinationPoint = new Vector2(transform.position.x + actionWidth /2 * cos, transform.position.y + actionWidth /2 * sin);


    }

    private void SetUpRails()
    {
        var rails = transform.parent.Find("Rails");
        var railsSpriteRenderer = rails.gameObject.GetComponent<SpriteRenderer>();
        var spriteSize = railsSpriteRenderer.bounds.size.x;

        float scale = actionWidth / spriteSize;

        rails.transform.localScale = new Vector3(scale, railsHeightMultuplier, 1f);
    }

    protected override void OnDrawGizmos()
    {
        base.OnDrawGizmos();

        //CalcPoints();

        /* float angle = transform.rotation.eulerAngles.z * Mathf.Deg2Rad;
         float cos = Mathf.Cos(angle);
         float sin = Mathf.Sin(angle);

         Vector2 startingPoint = new Vector2(startingTransform.position.x - actionWidth * cos, startingTransform.position.y - actionWidth * sin);
         Vector2 destinationPoint = new Vector2(startingTransform.position.x + actionWidth * cos, startingTransform.position.y + actionWidth * sin);

         Gizmos.DrawLine(startingPoint, destinationPoint);*/
    }


}
