DROP TABLE IF EXISTS reviews;
GO
CREATE TABLE reviews(
   platform            VARCHAR(15) NOT NULL PRIMARY KEY
  ,title               VARCHAR(161) NOT NULL
  ,"published by"      VARCHAR(69)
  ,"developed by"      VARCHAR(146)
  ,released            VARCHAR(12) NOT NULL
  ,genre               VARCHAR(70)
  ,perspective         VARCHAR(58)
  ,visual              VARCHAR(51)
  ,art                 VARCHAR(38)
  ,gameplay            VARCHAR(130)
  ,interface           VARCHAR(30)
  ,userReviews         VARCHAR(59)
  ,userReviewCount     INTEGER  NOT NULL
  ,averageUserReview   VARCHAR(18)
  ,criticReviews       VARCHAR(67)
  ,criticReviewCount   INTEGER  NOT NULL
  ,averageCriticReview VARCHAR(18)
);
