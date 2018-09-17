from ScoreKeeper import ScoreKeeper
from ScorePrinter import ScorePrinter

def main():
    add_to_player('Player 1')
    ScorePrinter.print_scores()
    add_to_player('Player 2')
    ScorePrinter.print_scores()
    add_to_player('Player 2')
    ScorePrinter.print_scores()
    add_to_player('Player 3')
    ScorePrinter.print_scores()
    add_to_player('Player 2')
    ScorePrinter.print_scores()


def add_to_player(player_name):
    singleton = ScoreKeeper.get_instance()

    print('Score given to {0}!'.format(player_name))

    singleton.increment_score(player_name)


if __name__ == '__main__':
    main()
