from ScoreKeeper import ScoreKeeper


class ScorePrinter:

    def __init__(self):
        pass

    @staticmethod
    def print_scores():
        singleton = ScoreKeeper.get_instance()

        scores = singleton.get_scores()

        for score in sorted(scores):
            print '{0} = {1}'.format(score, scores[score])

        print '----------'
