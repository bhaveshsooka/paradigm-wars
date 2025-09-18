module Main where

main :: IO ()
main = do
  putStrLn $ show $ A
  putStrLn $ show $ fromEnum A
  putStrLn "Hello, Haskell!"
  where

-- _ = move "C"

--

data Piece 
  = Knight Color
  | Bishop Color
  | Rook Color
  | King Color
  | Queen Color
  | Pawn Color

type Board = [(Block, Maybe Piece)]

data Block = Block BoardLetter BoardNumber

data Color
  = Black
  | White

data BoardLetter
  = A
  | B
  | C
  | D
  | E
  | F
  | G
  | H
  deriving (Show, Enum)

data BoardNumber
  = One
  | Two
  | Three
  | Four
  | Five
  | Six
  | Seven
  | Eight
  deriving (Show, Enum)

-- newtype E = E s

-- type BoarderLetter = "A" | "B"

-- move :: BoarderLetter -> Int
-- move b = 0

-- class Chess a where
--   move :: Piece -> Position -> Position -> String
